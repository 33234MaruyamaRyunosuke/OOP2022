
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btpush = new System.Windows.Forms.Button();
            this.nudnum1 = new System.Windows.Forms.NumericUpDown();
            this.nudnum2 = new System.Windows.Forms.NumericUpDown();
            this.nudAns = new System.Windows.Forms.NumericUpDown();
            this.nudMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(176, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "÷";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(344, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(489, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "あまり";
            // 
            // btpush
            // 
            this.btpush.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btpush.Location = new System.Drawing.Point(399, 223);
            this.btpush.Name = "btpush";
            this.btpush.Size = new System.Drawing.Size(75, 35);
            this.btpush.TabIndex = 7;
            this.btpush.Text = "計算";
            this.btpush.UseVisualStyleBackColor = true;
            this.btpush.Click += new System.EventHandler(this.btpush_Click);
            // 
            // nudnum1
            // 
            this.nudnum1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudnum1.Location = new System.Drawing.Point(50, 151);
            this.nudnum1.Name = "nudnum1";
            this.nudnum1.Size = new System.Drawing.Size(120, 28);
            this.nudnum1.TabIndex = 8;
            // 
            // nudnum2
            // 
            this.nudnum2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudnum2.Location = new System.Drawing.Point(218, 151);
            this.nudnum2.Name = "nudnum2";
            this.nudnum2.Size = new System.Drawing.Size(120, 28);
            this.nudnum2.TabIndex = 9;
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(373, 151);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(120, 28);
            this.nudAns.TabIndex = 10;
            // 
            // nudMod
            // 
            this.nudMod.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMod.Location = new System.Drawing.Point(587, 151);
            this.nudMod.Name = "nudMod";
            this.nudMod.Size = new System.Drawing.Size(120, 28);
            this.nudMod.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudMod);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.nudnum2);
            this.Controls.Add(this.nudnum1);
            this.Controls.Add(this.btpush);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "割り算アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.nudnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btpush;
        private System.Windows.Forms.NumericUpDown nudnum1;
        private System.Windows.Forms.NumericUpDown nudnum2;
        private System.Windows.Forms.NumericUpDown nudAns;
        private System.Windows.Forms.NumericUpDown nudMod;
    }
}

