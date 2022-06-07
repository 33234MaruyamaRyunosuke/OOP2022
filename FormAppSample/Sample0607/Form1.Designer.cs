
namespace Sample0607 {
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
            this.btRandom = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.Minnum = new System.Windows.Forms.NumericUpDown();
            this.Maxnum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxnum)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(442, 235);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(103, 75);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数取得";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(139, 239);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(168, 71);
            this.Number.TabIndex = 1;
            // 
            // Minnum
            // 
            this.Minnum.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Minnum.Location = new System.Drawing.Point(343, 101);
            this.Minnum.Name = "Minnum";
            this.Minnum.Size = new System.Drawing.Size(120, 39);
            this.Minnum.TabIndex = 2;
            // 
            // Maxnum
            // 
            this.Maxnum.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Maxnum.Location = new System.Drawing.Point(343, 162);
            this.Maxnum.Name = "Maxnum";
            this.Maxnum.Size = new System.Drawing.Size(120, 39);
            this.Maxnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(215, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "最小値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(215, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "最大値";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maxnum);
            this.Controls.Add(this.Minnum);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRandom);
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.NumericUpDown Minnum;
        private System.Windows.Forms.NumericUpDown Maxnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

