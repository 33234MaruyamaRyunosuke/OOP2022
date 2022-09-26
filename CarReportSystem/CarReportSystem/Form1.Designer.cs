﻿
namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cdColorSelect = new System.Windows.Forms.ColorDialog();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.ofdCarReportOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdCarReportSave = new System.Windows.Forms.SaveFileDialog();
            this.btOpenReport = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btSaveReport = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btModifyReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.cbAuther = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.infosys202222DataSet = new CarReportSystem.infosys202222DataSet();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportDBTableAdapter = new CarReportSystem.infosys202222DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202222DataSetTableAdapters.TableAdapterManager();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202222DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(78, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "レポート：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(78, 134);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(240, 20);
            this.cbCarName.TabIndex = 4;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(78, 169);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(305, 98);
            this.tbReport.TabIndex = 5;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(522, 88);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(235, 145);
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(78, 103);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 8;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(131, 103);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 9;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(184, 103);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 10;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(241, 103);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 11;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(299, 103);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(59, 16);
            this.rbImport.TabIndex = 12;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "外国車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(364, 103);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 13;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // ofdCarReportOpen
            // 
            this.ofdCarReportOpen.FileName = "openFileDialog1";
            // 
            // btOpenReport
            // 
            this.btOpenReport.Location = new System.Drawing.Point(12, 348);
            this.btOpenReport.Name = "btOpenReport";
            this.btOpenReport.Size = new System.Drawing.Size(75, 23);
            this.btOpenReport.TabIndex = 14;
            this.btOpenReport.Text = "開く...";
            this.btOpenReport.UseVisualStyleBackColor = true;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(600, 59);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 15;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // btSaveReport
            // 
            this.btSaveReport.Location = new System.Drawing.Point(12, 377);
            this.btSaveReport.Name = "btSaveReport";
            this.btSaveReport.Size = new System.Drawing.Size(75, 23);
            this.btSaveReport.TabIndex = 16;
            this.btSaveReport.Text = "保存";
            this.btSaveReport.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 406);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 17;
            this.btExit.Text = "閉じる";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btAddReport
            // 
            this.btAddReport.Location = new System.Drawing.Point(522, 245);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(68, 37);
            this.btAddReport.TabIndex = 18;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = true;
            // 
            // btModifyReport
            // 
            this.btModifyReport.Location = new System.Drawing.Point(607, 245);
            this.btModifyReport.Name = "btModifyReport";
            this.btModifyReport.Size = new System.Drawing.Size(68, 37);
            this.btModifyReport.TabIndex = 19;
            this.btModifyReport.Text = "編集";
            this.btModifyReport.UseVisualStyleBackColor = true;
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.Location = new System.Drawing.Point(691, 245);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(68, 37);
            this.btDeleteReport.TabIndex = 20;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(684, 59);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(75, 23);
            this.btPictureDelete.TabIndex = 21;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            // 
            // cbAuther
            // 
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(78, 65);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(240, 20);
            this.cbAuther.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "記事一覧：";
            // 
            // infosys202222DataSet
            // 
            this.infosys202222DataSet.DataSetName = "infosys202222DataSet";
            this.infosys202222DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202222DataSet;
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202222DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(88, 288);
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(749, 220);
            this.carReportDBDataGridView.TabIndex = 27;
            this.carReportDBDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carReportDBDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 525);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAuther);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btModifyReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSaveReport);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btOpenReport);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbImport);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202222DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ColorDialog cdColorSelect;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.OpenFileDialog ofdCarReportOpen;
        private System.Windows.Forms.SaveFileDialog sfdCarReportSave;
        private System.Windows.Forms.Button btOpenReport;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btSaveReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btModifyReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.ComboBox cbAuther;
        private System.Windows.Forms.Label label6;
        private infosys202222DataSet infosys202222DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202222DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202222DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
    }
}

