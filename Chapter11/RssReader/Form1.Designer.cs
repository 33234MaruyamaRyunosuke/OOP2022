
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbRSSurl = new System.Windows.Forms.ComboBox();
            this.btRSSget = new System.Windows.Forms.Button();
            this.lbRSSTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbRSSurl
            // 
            this.cbRSSurl.FormattingEnabled = true;
            this.cbRSSurl.Location = new System.Drawing.Point(12, 29);
            this.cbRSSurl.Name = "cbRSSurl";
            this.cbRSSurl.Size = new System.Drawing.Size(757, 20);
            this.cbRSSurl.TabIndex = 0;
            this.cbRSSurl.SelectedIndexChanged += new System.EventHandler(this.btRSSget_Click);
            // 
            // btRSSget
            // 
            this.btRSSget.Location = new System.Drawing.Point(775, 27);
            this.btRSSget.Name = "btRSSget";
            this.btRSSget.Size = new System.Drawing.Size(75, 23);
            this.btRSSget.TabIndex = 1;
            this.btRSSget.Text = "取得";
            this.btRSSget.UseVisualStyleBackColor = true;
            this.btRSSget.Click += new System.EventHandler(this.btRSSget_Click);
            // 
            // lbRSSTitle
            // 
            this.lbRSSTitle.FormattingEnabled = true;
            this.lbRSSTitle.ItemHeight = 12;
            this.lbRSSTitle.Location = new System.Drawing.Point(12, 58);
            this.lbRSSTitle.Name = "lbRSSTitle";
            this.lbRSSTitle.Size = new System.Drawing.Size(229, 556);
            this.lbRSSTitle.TabIndex = 2;
            this.lbRSSTitle.SelectedIndexChanged += new System.EventHandler(this.btRSSget_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(247, 58);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(622, 553);
            this.wbBrowser.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 623);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRSSTitle);
            this.Controls.Add(this.btRSSget);
            this.Controls.Add(this.cbRSSurl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRSSurl;
        private System.Windows.Forms.Button btRSSget;
        private System.Windows.Forms.ListBox lbRSSTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}

