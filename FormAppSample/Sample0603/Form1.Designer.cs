
namespace Sample0603 {
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
            this.btpush = new System.Windows.Forms.Button();
            this.tbSuu1 = new System.Windows.Forms.TextBox();
            this.tbSuu2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSuu1 = new System.Windows.Forms.NumericUpDown();
            this.nudSuu2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAns = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
            this.SuspendLayout();
            // 
            // btpush
            // 
            this.btpush.BackColor = System.Drawing.Color.Yellow;
            this.btpush.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btpush.Location = new System.Drawing.Point(264, 33);
            this.btpush.Name = "btpush";
            this.btpush.Size = new System.Drawing.Size(170, 100);
            this.btpush.TabIndex = 0;
            this.btpush.Text = "計算";
            this.btpush.UseVisualStyleBackColor = false;
            this.btpush.Click += new System.EventHandler(this.btpush_Click);
            // 
            // tbSuu1
            // 
            this.tbSuu1.Location = new System.Drawing.Point(102, 244);
            this.tbSuu1.Name = "tbSuu1";
            this.tbSuu1.Size = new System.Drawing.Size(122, 18);
            this.tbSuu1.TabIndex = 1;
            // 
            // tbSuu2
            // 
            this.tbSuu2.Location = new System.Drawing.Point(291, 244);
            this.tbSuu2.Name = "tbSuu2";
            this.tbSuu2.Size = new System.Drawing.Size(118, 18);
            this.tbSuu2.TabIndex = 2;
            // 
            // tbAns
            // 
            this.tbAns.Location = new System.Drawing.Point(486, 244);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(100, 18);
            this.tbAns.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(243, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(438, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // nudSuu1
            // 
            this.nudSuu1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu1.Location = new System.Drawing.Point(102, 177);
            this.nudSuu1.Name = "nudSuu1";
            this.nudSuu1.Size = new System.Drawing.Size(120, 31);
            this.nudSuu1.TabIndex = 6;
            // 
            // nudSuu2
            // 
            this.nudSuu2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu2.Location = new System.Drawing.Point(291, 175);
            this.nudSuu2.Name = "nudSuu2";
            this.nudSuu2.Size = new System.Drawing.Size(120, 31);
            this.nudSuu2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(243, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(438, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(486, 175);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(120, 31);
            this.nudAns.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(695, 371);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSuu2);
            this.Controls.Add(this.nudSuu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbSuu2);
            this.Controls.Add(this.tbSuu1);
            this.Controls.Add(this.btpush);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btpush;
        private System.Windows.Forms.TextBox tbSuu1;
        private System.Windows.Forms.TextBox tbSuu2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSuu1;
        private System.Windows.Forms.NumericUpDown nudSuu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAns;
    }
}

