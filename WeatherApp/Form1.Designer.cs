
namespace WeatherApp {
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
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbWeatherIcon = new System.Windows.Forms.PictureBox();
            this.tbPresenter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbJapanMap = new System.Windows.Forms.PictureBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btHokkaido = new System.Windows.Forms.Button();
            this.btTohoku = new System.Windows.Forms.Button();
            this.btKantoKousinetu = new System.Windows.Forms.Button();
            this.btHokuriku = new System.Windows.Forms.Button();
            this.btTokai = new System.Windows.Forms.Button();
            this.btKinki = new System.Windows.Forms.Button();
            this.btTyugokuSikoku = new System.Windows.Forms.Button();
            this.btKyusyu = new System.Windows.Forms.Button();
            this.btOkinawa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJapanMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("ＭＳ 明朝", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGet.Location = new System.Drawing.Point(242, 80);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(111, 49);
            this.btWeatherGet.TabIndex = 0;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(93, 146);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(289, 371);
            this.tbWeatherInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "地域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 11);
            this.label3.TabIndex = 5;
            this.label3.Text = "発表者";
            // 
            // pbWeatherIcon
            // 
            this.pbWeatherIcon.Location = new System.Drawing.Point(372, 42);
            this.pbWeatherIcon.Name = "pbWeatherIcon";
            this.pbWeatherIcon.Size = new System.Drawing.Size(100, 87);
            this.pbWeatherIcon.TabIndex = 6;
            this.pbWeatherIcon.TabStop = false;
            // 
            // tbPresenter
            // 
            this.tbPresenter.Location = new System.Drawing.Point(59, 5);
            this.tbPresenter.Name = "tbPresenter";
            this.tbPresenter.Size = new System.Drawing.Size(121, 19);
            this.tbPresenter.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "明日の天気";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "明後日の天気";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "週間予報";
            // 
            // pbJapanMap
            // 
            this.pbJapanMap.Location = new System.Drawing.Point(416, 146);
            this.pbJapanMap.Name = "pbJapanMap";
            this.pbJapanMap.Size = new System.Drawing.Size(400, 400);
            this.pbJapanMap.TabIndex = 12;
            this.pbJapanMap.TabStop = false;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(102, 95);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 20);
            this.cbRegion.TabIndex = 13;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(216, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btHokkaido
            // 
            this.btHokkaido.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHokkaido.Location = new System.Drawing.Point(579, 181);
            this.btHokkaido.Name = "btHokkaido";
            this.btHokkaido.Size = new System.Drawing.Size(66, 33);
            this.btHokkaido.TabIndex = 16;
            this.btHokkaido.Text = "北海道";
            this.btHokkaido.UseVisualStyleBackColor = true;
            this.btHokkaido.Click += new System.EventHandler(this.btHokkaido_Click);
            // 
            // btTohoku
            // 
            this.btTohoku.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTohoku.Location = new System.Drawing.Point(714, 301);
            this.btTohoku.Name = "btTohoku";
            this.btTohoku.Size = new System.Drawing.Size(55, 33);
            this.btTohoku.TabIndex = 17;
            this.btTohoku.Text = "東北";
            this.btTohoku.UseVisualStyleBackColor = true;
            this.btTohoku.Click += new System.EventHandler(this.btTohoku_Click);
            // 
            // btKantoKousinetu
            // 
            this.btKantoKousinetu.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKantoKousinetu.Location = new System.Drawing.Point(694, 383);
            this.btKantoKousinetu.Name = "btKantoKousinetu";
            this.btKantoKousinetu.Size = new System.Drawing.Size(94, 33);
            this.btKantoKousinetu.TabIndex = 18;
            this.btKantoKousinetu.Text = "関東甲信越";
            this.btKantoKousinetu.UseVisualStyleBackColor = true;
            this.btKantoKousinetu.Click += new System.EventHandler(this.btKantoKousinetu_Click);
            // 
            // btHokuriku
            // 
            this.btHokuriku.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHokuriku.Location = new System.Drawing.Point(548, 318);
            this.btHokuriku.Name = "btHokuriku";
            this.btHokuriku.Size = new System.Drawing.Size(66, 33);
            this.btHokuriku.TabIndex = 19;
            this.btHokuriku.Text = "北陸";
            this.btHokuriku.UseVisualStyleBackColor = true;
            this.btHokuriku.Click += new System.EventHandler(this.btHokuriku_Click);
            // 
            // btTokai
            // 
            this.btTokai.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTokai.Location = new System.Drawing.Point(620, 440);
            this.btTokai.Name = "btTokai";
            this.btTokai.Size = new System.Drawing.Size(66, 33);
            this.btTokai.TabIndex = 20;
            this.btTokai.Text = "東海";
            this.btTokai.UseVisualStyleBackColor = true;
            this.btTokai.Click += new System.EventHandler(this.btTokai_Click);
            // 
            // btKinki
            // 
            this.btKinki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKinki.Location = new System.Drawing.Point(548, 471);
            this.btKinki.Name = "btKinki";
            this.btKinki.Size = new System.Drawing.Size(66, 33);
            this.btKinki.TabIndex = 21;
            this.btKinki.Text = "近畿";
            this.btKinki.UseVisualStyleBackColor = true;
            this.btKinki.Click += new System.EventHandler(this.btKinki_Click);
            // 
            // btTyugokuSikoku
            // 
            this.btTyugokuSikoku.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTyugokuSikoku.Location = new System.Drawing.Point(451, 370);
            this.btTyugokuSikoku.Name = "btTyugokuSikoku";
            this.btTyugokuSikoku.Size = new System.Drawing.Size(91, 33);
            this.btTyugokuSikoku.TabIndex = 22;
            this.btTyugokuSikoku.Text = "中国・四国";
            this.btTyugokuSikoku.UseVisualStyleBackColor = true;
            this.btTyugokuSikoku.Click += new System.EventHandler(this.btTyugokuSikoku_Click);
            // 
            // btKyusyu
            // 
            this.btKyusyu.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKyusyu.Location = new System.Drawing.Point(485, 510);
            this.btKyusyu.Name = "btKyusyu";
            this.btKyusyu.Size = new System.Drawing.Size(66, 33);
            this.btKyusyu.TabIndex = 23;
            this.btKyusyu.Text = "九州";
            this.btKyusyu.UseVisualStyleBackColor = true;
            this.btKyusyu.Click += new System.EventHandler(this.btKyusyu_Click);
            // 
            // btOkinawa
            // 
            this.btOkinawa.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOkinawa.Location = new System.Drawing.Point(732, 455);
            this.btOkinawa.Name = "btOkinawa";
            this.btOkinawa.Size = new System.Drawing.Size(66, 33);
            this.btOkinawa.TabIndex = 24;
            this.btOkinawa.Text = "沖縄";
            this.btOkinawa.UseVisualStyleBackColor = true;
            this.btOkinawa.Click += new System.EventHandler(this.btOkinawa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(828, 671);
            this.Controls.Add(this.btOkinawa);
            this.Controls.Add(this.btKyusyu);
            this.Controls.Add(this.btTyugokuSikoku);
            this.Controls.Add(this.btKinki);
            this.Controls.Add(this.btTokai);
            this.Controls.Add(this.btHokuriku);
            this.Controls.Add(this.btKantoKousinetu);
            this.Controls.Add(this.btTohoku);
            this.Controls.Add(this.btHokkaido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.pbJapanMap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPresenter);
            this.Controls.Add(this.pbWeatherIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.btWeatherGet);
            this.Name = "Form1";
            this.Text = "天気アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJapanMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbWeatherIcon;
        private System.Windows.Forms.TextBox tbPresenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbJapanMap;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btHokkaido;
        private System.Windows.Forms.Button btTohoku;
        private System.Windows.Forms.Button btKantoKousinetu;
        private System.Windows.Forms.Button btHokuriku;
        private System.Windows.Forms.Button btTokai;
        private System.Windows.Forms.Button btKinki;
        private System.Windows.Forms.Button btTyugokuSikoku;
        private System.Windows.Forms.Button btKyusyu;
        private System.Windows.Forms.Button btOkinawa;
    }
}

