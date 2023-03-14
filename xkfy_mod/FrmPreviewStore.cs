using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xkfy_mod.Domain;
using xkfy_mod.Facade;

namespace xkfy_mod
{
    public partial class FrmPreviewStore : Form
    {
        private StoreItemFacade storeItemFacade;
        public FrmPreviewStore()
        {
            InitializeComponent();
            string mainPage = Helper.WebMixinHelper.GetContentAbsolutePath("PreviewStore");
            this.webViewController.Source = new Uri(mainPage);
            storeItemFacade = new StoreItemFacade();
        }

        private void FrmPreviewStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void webViewController_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webViewController.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            this.webViewController.CoreWebView2.Settings.IsWebMessageEnabled = true;
            this.webViewController.CoreWebView2.Settings.AreDevToolsEnabled = true;
        }

        private void webViewController_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            //Domain.StoreItem item = new Domain.StoreItem
            //{
            //    StoreName = "老王",
            //    ProductName = "testProduct",
            //    Quantity = 1,
            //    Possibility = 70,
            //    Price = 2000
            //};
            Dictionary<string, List<StoreItem>> items = storeItemFacade.GetStoreInformationMap();
            var sample = JsonConvert.SerializeObject(items);
            this.webViewController.CoreWebView2.PostWebMessageAsJson(sample);
        }
    }
}
