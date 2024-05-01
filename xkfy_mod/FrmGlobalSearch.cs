using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xkfy_mod.Entity;
using xkfy_mod.Helper;

namespace xkfy_mod
{
    public partial class FrmGlobalSearch : Form
    {
        public FrmGlobalSearch()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (IsInvalidInput())
                return;

            string keyword = GetKeyword();

            List<MatchItem> matches = new List<MatchItem>();
            // step 1: load all data tables which are not in memory
            FileHelper.LoadAllTables();
            foreach (DataTable dataTable in DataHelper.XkfyData.Tables)
            {
                // step 2: query each cell in every table
                List<MatchItem> matchesInThisTable = QueryMatchItem(dataTable, keyword);
                matches.AddRange(matchesInThisTable);
            }

            DisplayMatchResult(matches);
        }

        private void DisplayMatchResult(List<MatchItem> matches)
        {
            StringBuilder sb = new StringBuilder();
            if (matches.Any())
            {
                foreach (MatchItem matchItem in matches)
                {
                    sb.Append("表名：").Append(matchItem.TableName).Append('\t');
                    sb.Append("列名：").Append(matchItem.ColumnName).Append('\t');
                    sb.Append("具体值：").Append(matchItem.ColumnValue).Append('\t');
                    sb.Append("\r\n");
                }
            } else
            {
                sb.Append("未查询到匹配结果");
            }

            DisplayOnForm(sb.ToString());
            
        }

        private void DisplayOnForm(string v)
        {
            TbResult.Text = v;
        }

        private List<MatchItem> QueryMatchItem(DataTable dataTable, string queryString)
        {
            List<MatchItem> items = new List<MatchItem>();
            int columnNumber = dataTable.Columns.Count;
            foreach(DataRow row in dataTable.Rows)
            {
                for(int i = 0; i < columnNumber; i++)
                {
                    if (row[i].ToString().Contains(queryString))
                    {
                        items.Add(
                            new MatchItem { 
                                TableName=dataTable.TableName, 
                                ColumnName=dataTable.Columns[i].ColumnName, 
                                ColumnValue=row[i].ToString()
                            });
                    }
                }
            }
            return items; 
        }

        private string GetKeyword()
        {
            return this.tbKeyWord.Text;
        }

        private bool IsInvalidInput()
        {
            return this.tbKeyWord.Text == null || this.tbKeyWord.Text.Length == 0;
        }
    }
}
