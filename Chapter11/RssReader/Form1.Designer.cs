
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
            this.btback = new System.Windows.Forms.Button();
            this.btforward = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRSSurl
            // 
            this.cbRSSurl.FormattingEnabled = true;
            this.cbRSSurl.Location = new System.Drawing.Point(12, 29);
            this.cbRSSurl.Name = "cbRSSurl";
            this.cbRSSurl.Size = new System.Drawing.Size(614, 20);
            this.cbRSSurl.TabIndex = 0;
            this.cbRSSurl.SelectedIndexChanged += new System.EventHandler(this.btRSSget_Click);
            // 
            // btRSSget
            // 
            this.btRSSget.Location = new System.Drawing.Point(632, 29);
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
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(744, 12);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(44, 40);
            this.btback.TabIndex = 4;
            this.btback.Text = "🔙";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btforward
            // 
            this.btforward.Location = new System.Drawing.Point(794, 12);
            this.btforward.Name = "btforward";
            this.btforward.Size = new System.Drawing.Size(44, 40);
            this.btforward.TabIndex = 5;
            this.btforward.Text = "🔜";
            this.btforward.UseVisualStyleBackColor = true;
            this.btforward.Click += new System.EventHandler(this.btforward_Click);
            // 
            // wvBrowser
            // 
            this.wvBrowser.Location = new System.Drawing.Point(322, 172);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(416, 378);
            this.wvBrowser.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 623);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btforward);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRSSTitle);
            this.Controls.Add(this.btRSSget);
            this.Controls.Add(this.cbRSSurl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRSSurl;
        private System.Windows.Forms.Button btRSSget;
        private System.Windows.Forms.ListBox lbRSSTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btforward;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

