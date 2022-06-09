
namespace NumberGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DomainUpDown();
            this.Judge = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(225, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "の中で好きな数字を入力";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(127, 149);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 34);
            this.Number.TabIndex = 1;
            this.Number.Text = "0";
            // 
            // Judge
            // 
            this.Judge.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Judge.Location = new System.Drawing.Point(326, 131);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(110, 67);
            this.Judge.TabIndex = 2;
            this.Judge.Text = "判定!";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(101, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 28);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "1から";
            // 
            // MaxNum
            // 
            this.MaxNum.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxNum.Location = new System.Drawing.Point(141, 71);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(78, 31);
            this.MaxNum.TabIndex = 5;
            this.MaxNum.ValueChanged += new System.EventHandler(this.MaxNum_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 329);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown Number;
        private System.Windows.Forms.Button Judge;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxNum;
    }
}

