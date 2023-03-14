namespace xkfy_mod
{
    partial class FrmPreviewStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webViewController = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewController)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewController
            // 
            this.webViewController.AllowExternalDrop = true;
            this.webViewController.CreationProperties = null;
            this.webViewController.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewController.Location = new System.Drawing.Point(0, 0);
            this.webViewController.Name = "webViewController";
            this.webViewController.Size = new System.Drawing.Size(1006, 721);
            this.webViewController.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewController.TabIndex = 0;
            this.webViewController.ZoomFactor = 1D;
            this.webViewController.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webViewController_CoreWebView2InitializationCompleted);
            this.webViewController.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webViewController_NavigationCompleted);
            // 
            // FrmPreviewStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.webViewController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPreviewStore";
            this.Text = "商店预览";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPreviewStore_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.webViewController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewController;
    }
}