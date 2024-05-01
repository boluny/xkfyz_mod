namespace xkfy_mod
{
    partial class FrmGlobalSearch
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
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(113, 35);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(257, 25);
            this.tbKeyWord.TabIndex = 0;
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.Location = new System.Drawing.Point(40, 38);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(67, 15);
            this.lblKeyWord.TabIndex = 1;
            this.lblKeyWord.Text = "关键词：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(395, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbResult
            // 
            this.TbResult.Location = new System.Drawing.Point(43, 109);
            this.TbResult.Multiline = true;
            this.TbResult.Name = "TbResult";
            this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbResult.Size = new System.Drawing.Size(936, 456);
            this.TbResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(490, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "注意：该操作容易导致工具无响应，请保存好当前改动";
            // 
            // FrmGlobalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.tbKeyWord);
            this.Name = "FrmGlobalSearch";
            this.Text = "全局搜索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.Label label1;
    }
}