namespace WinformsDUCCompany1a.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.tpPosition = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.PoPositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDailySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPoDailySalary = new MaterialSkin.Controls.MaterialTextBox();
            this.btnResetPo = new MaterialSkin.Controls.MaterialButton();
            this.btnDeletePo = new MaterialSkin.Controls.MaterialButton();
            this.btnSavePo = new MaterialSkin.Controls.MaterialButton();
            this.txtPoPositionName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbPoDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tpDapartment = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.DeDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetDe = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteDe = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveDe = new MaterialSkin.Controls.MaterialButton();
            this.txtDeDepartmentName = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tpSalary = new System.Windows.Forms.TabPage();
            this.btnSaExportToPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnSaExportToExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnSaPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnSaShowMoSalary = new MaterialSkin.Controls.MaterialButton();
            this.btnSaSearchById = new MaterialSkin.Controls.MaterialButton();
            this.txtSaSearchEmpById = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSaEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelProRole = new System.Windows.Forms.Label();
            this.LabelProEmail = new System.Windows.Forms.Label();
            this.LabelProUsername = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tpCRUD = new System.Windows.Forms.TabPage();
            this.btnResetEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnClearEmpPhoto = new MaterialSkin.Controls.MaterialButton();
            this.btnUploadEmpPhoto = new MaterialSkin.Controls.MaterialButton();
            this.txtEmpAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtEmpName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbEmpPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpGender = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbEmpPhoto = new System.Windows.Forms.PictureBox();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.btnShowAll = new MaterialSkin.Controls.MaterialButton();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.btnExportToPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnExportToExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.txtSearchEmpByName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbHomeDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.tpDapartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tpSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaEmployees)).BeginInit();
            this.tpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpPhoto)).BeginInit();
            this.tpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home256.png");
            this.imageList1.Images.SetKeyName(1, "group_people256.png");
            this.imageList1.Images.SetKeyName(2, "work256.png");
            this.imageList1.Images.SetKeyName(3, "salary256.png");
            this.imageList1.Images.SetKeyName(4, "chart256.png");
            this.imageList1.Images.SetKeyName(5, "user256.png");
            this.imageList1.Images.SetKeyName(6, "logout256.png");
            this.imageList1.Images.SetKeyName(7, "people256.png");
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // tpPosition
            // 
            this.tpPosition.Controls.Add(this.pictureBox4);
            this.tpPosition.Controls.Add(this.dgvPositions);
            this.tpPosition.Controls.Add(this.label10);
            this.tpPosition.Controls.Add(this.txtPoDailySalary);
            this.tpPosition.Controls.Add(this.btnResetPo);
            this.tpPosition.Controls.Add(this.btnDeletePo);
            this.tpPosition.Controls.Add(this.btnSavePo);
            this.tpPosition.Controls.Add(this.txtPoPositionName);
            this.tpPosition.Controls.Add(this.cmbPoDepartment);
            this.tpPosition.Controls.Add(this.label9);
            this.tpPosition.Controls.Add(this.label8);
            this.tpPosition.Controls.Add(this.materialLabel5);
            this.tpPosition.ImageKey = "work256.png";
            this.tpPosition.Location = new System.Drawing.Point(4, 31);
            this.tpPosition.Name = "tpPosition";
            this.tpPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tpPosition.Size = new System.Drawing.Size(986, 508);
            this.tpPosition.TabIndex = 8;
            this.tpPosition.Text = "Position";
            this.tpPosition.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinformsDUCCompany1a.Properties.Resources.work256;
            this.pictureBox4.Location = new System.Drawing.Point(430, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 68;
            this.pictureBox4.TabStop = false;
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoPositionId,
            this.PoPositionName,
            this.PoDepartmentName,
            this.PoDailySalary});
            this.dgvPositions.Location = new System.Drawing.Point(385, 144);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.Size = new System.Drawing.Size(509, 150);
            this.dgvPositions.TabIndex = 67;
            this.dgvPositions.DoubleClick += new System.EventHandler(this.dgvPositions_DoubleClick);
            // 
            // PoPositionId
            // 
            this.PoPositionId.DataPropertyName = "PositionId";
            this.PoPositionId.HeaderText = "Id ";
            this.PoPositionId.Name = "PoPositionId";
            this.PoPositionId.Width = 40;
            // 
            // PoPositionName
            // 
            this.PoPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PoPositionName.DataPropertyName = "PositionName";
            this.PoPositionName.HeaderText = "Name ";
            this.PoPositionName.Name = "PoPositionName";
            // 
            // PoDepartmentName
            // 
            this.PoDepartmentName.DataPropertyName = "DepartmentName";
            this.PoDepartmentName.HeaderText = "Department Name ";
            this.PoDepartmentName.Name = "PoDepartmentName";
            this.PoDepartmentName.Width = 150;
            // 
            // PoDailySalary
            // 
            this.PoDailySalary.DataPropertyName = "DailySalary";
            this.PoDailySalary.HeaderText = "Daily Salary ";
            this.PoDailySalary.Name = "PoDailySalary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Daily Salary ";
            // 
            // txtPoDailySalary
            // 
            this.txtPoDailySalary.AnimateReadOnly = false;
            this.txtPoDailySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoDailySalary.Depth = 0;
            this.txtPoDailySalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPoDailySalary.LeadingIcon = null;
            this.txtPoDailySalary.Location = new System.Drawing.Point(135, 274);
            this.txtPoDailySalary.MaxLength = 50;
            this.txtPoDailySalary.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPoDailySalary.Multiline = false;
            this.txtPoDailySalary.Name = "txtPoDailySalary";
            this.txtPoDailySalary.Size = new System.Drawing.Size(221, 50);
            this.txtPoDailySalary.TabIndex = 65;
            this.txtPoDailySalary.Text = "";
            this.txtPoDailySalary.TrailingIcon = null;
            // 
            // btnResetPo
            // 
            this.btnResetPo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetPo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetPo.Depth = 0;
            this.btnResetPo.HighEmphasis = true;
            this.btnResetPo.Icon = null;
            this.btnResetPo.Location = new System.Drawing.Point(211, 349);
            this.btnResetPo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetPo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetPo.Name = "btnResetPo";
            this.btnResetPo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetPo.Size = new System.Drawing.Size(65, 36);
            this.btnResetPo.TabIndex = 62;
            this.btnResetPo.Text = "Reset";
            this.btnResetPo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetPo.UseAccentColor = false;
            this.btnResetPo.UseVisualStyleBackColor = true;
            this.btnResetPo.Click += new System.EventHandler(this.btnResetPo_Click);
            // 
            // btnDeletePo
            // 
            this.btnDeletePo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletePo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletePo.Depth = 0;
            this.btnDeletePo.HighEmphasis = true;
            this.btnDeletePo.Icon = null;
            this.btnDeletePo.Location = new System.Drawing.Point(111, 349);
            this.btnDeletePo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletePo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletePo.Name = "btnDeletePo";
            this.btnDeletePo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletePo.Size = new System.Drawing.Size(73, 36);
            this.btnDeletePo.TabIndex = 61;
            this.btnDeletePo.Text = "Delete";
            this.btnDeletePo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletePo.UseAccentColor = false;
            this.btnDeletePo.UseVisualStyleBackColor = true;
            this.btnDeletePo.Click += new System.EventHandler(this.btnDeletePo_Click);
            // 
            // btnSavePo
            // 
            this.btnSavePo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSavePo.Depth = 0;
            this.btnSavePo.HighEmphasis = true;
            this.btnSavePo.Icon = null;
            this.btnSavePo.Location = new System.Drawing.Point(16, 349);
            this.btnSavePo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSavePo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePo.Name = "btnSavePo";
            this.btnSavePo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSavePo.Size = new System.Drawing.Size(64, 36);
            this.btnSavePo.TabIndex = 60;
            this.btnSavePo.Text = "Save";
            this.btnSavePo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSavePo.UseAccentColor = false;
            this.btnSavePo.UseVisualStyleBackColor = true;
            this.btnSavePo.Click += new System.EventHandler(this.btnSavePo_Click);
            // 
            // txtPoPositionName
            // 
            this.txtPoPositionName.AnimateReadOnly = false;
            this.txtPoPositionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoPositionName.Depth = 0;
            this.txtPoPositionName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPoPositionName.LeadingIcon = null;
            this.txtPoPositionName.Location = new System.Drawing.Point(135, 144);
            this.txtPoPositionName.MaxLength = 50;
            this.txtPoPositionName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPoPositionName.Multiline = false;
            this.txtPoPositionName.Name = "txtPoPositionName";
            this.txtPoPositionName.Size = new System.Drawing.Size(221, 50);
            this.txtPoPositionName.TabIndex = 58;
            this.txtPoPositionName.Text = "";
            this.txtPoPositionName.TrailingIcon = null;
            // 
            // cmbPoDepartment
            // 
            this.cmbPoDepartment.AutoResize = false;
            this.cmbPoDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPoDepartment.Depth = 0;
            this.cmbPoDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPoDepartment.DropDownHeight = 174;
            this.cmbPoDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoDepartment.DropDownWidth = 121;
            this.cmbPoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPoDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPoDepartment.FormattingEnabled = true;
            this.cmbPoDepartment.IntegralHeight = false;
            this.cmbPoDepartment.ItemHeight = 43;
            this.cmbPoDepartment.Location = new System.Drawing.Point(135, 209);
            this.cmbPoDepartment.MaxDropDownItems = 4;
            this.cmbPoDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPoDepartment.Name = "cmbPoDepartment";
            this.cmbPoDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbPoDepartment.StartIndex = 0;
            this.cmbPoDepartment.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(332, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(237, 41);
            this.materialLabel5.TabIndex = 57;
            this.materialLabel5.Text = "CRUD Positions";
            // 
            // tpDapartment
            // 
            this.tpDapartment.Controls.Add(this.pictureBox3);
            this.tpDapartment.Controls.Add(this.dgvDepartments);
            this.tpDapartment.Controls.Add(this.btnResetDe);
            this.tpDapartment.Controls.Add(this.btnDeleteDe);
            this.tpDapartment.Controls.Add(this.btnSaveDe);
            this.tpDapartment.Controls.Add(this.txtDeDepartmentName);
            this.tpDapartment.Controls.Add(this.label7);
            this.tpDapartment.Controls.Add(this.materialLabel4);
            this.tpDapartment.ImageKey = "people256.png";
            this.tpDapartment.Location = new System.Drawing.Point(4, 31);
            this.tpDapartment.Name = "tpDapartment";
            this.tpDapartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpDapartment.Size = new System.Drawing.Size(986, 508);
            this.tpDapartment.TabIndex = 7;
            this.tpDapartment.Text = "Department";
            this.tpDapartment.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinformsDUCCompany1a.Properties.Resources.people256;
            this.pictureBox3.Location = new System.Drawing.Point(455, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeDepartmentId,
            this.DeDepartmentName});
            this.dgvDepartments.Location = new System.Drawing.Point(386, 170);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(365, 150);
            this.dgvDepartments.TabIndex = 53;
            this.dgvDepartments.DoubleClick += new System.EventHandler(this.dgvDepartments_DoubleClick);
            // 
            // DeDepartmentId
            // 
            this.DeDepartmentId.DataPropertyName = "DepartmentId";
            this.DeDepartmentId.HeaderText = "Id ";
            this.DeDepartmentId.Name = "DeDepartmentId";
            this.DeDepartmentId.Width = 40;
            // 
            // DeDepartmentName
            // 
            this.DeDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeDepartmentName.DataPropertyName = "DepartmentName";
            this.DeDepartmentName.HeaderText = "Name ";
            this.DeDepartmentName.Name = "DeDepartmentName";
            // 
            // btnResetDe
            // 
            this.btnResetDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetDe.Depth = 0;
            this.btnResetDe.HighEmphasis = true;
            this.btnResetDe.Icon = null;
            this.btnResetDe.Location = new System.Drawing.Point(205, 244);
            this.btnResetDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetDe.Name = "btnResetDe";
            this.btnResetDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetDe.Size = new System.Drawing.Size(65, 36);
            this.btnResetDe.TabIndex = 52;
            this.btnResetDe.Text = "Reset";
            this.btnResetDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetDe.UseAccentColor = false;
            this.btnResetDe.UseVisualStyleBackColor = true;
            this.btnResetDe.Click += new System.EventHandler(this.btnResetDe_Click);
            // 
            // btnDeleteDe
            // 
            this.btnDeleteDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteDe.Depth = 0;
            this.btnDeleteDe.HighEmphasis = true;
            this.btnDeleteDe.Icon = null;
            this.btnDeleteDe.Location = new System.Drawing.Point(105, 244);
            this.btnDeleteDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteDe.Name = "btnDeleteDe";
            this.btnDeleteDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteDe.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteDe.TabIndex = 51;
            this.btnDeleteDe.Text = "Delete";
            this.btnDeleteDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteDe.UseAccentColor = false;
            this.btnDeleteDe.UseVisualStyleBackColor = true;
            this.btnDeleteDe.Click += new System.EventHandler(this.btnDeleteDe_Click);
            // 
            // btnSaveDe
            // 
            this.btnSaveDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveDe.Depth = 0;
            this.btnSaveDe.HighEmphasis = true;
            this.btnSaveDe.Icon = null;
            this.btnSaveDe.Location = new System.Drawing.Point(13, 244);
            this.btnSaveDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDe.Name = "btnSaveDe";
            this.btnSaveDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveDe.Size = new System.Drawing.Size(64, 36);
            this.btnSaveDe.TabIndex = 50;
            this.btnSaveDe.Text = "Save";
            this.btnSaveDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveDe.UseAccentColor = false;
            this.btnSaveDe.UseVisualStyleBackColor = true;
            this.btnSaveDe.Click += new System.EventHandler(this.btnSaveDe_Click);
            // 
            // txtDeDepartmentName
            // 
            this.txtDeDepartmentName.AnimateReadOnly = false;
            this.txtDeDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeDepartmentName.Depth = 0;
            this.txtDeDepartmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeDepartmentName.LeadingIcon = null;
            this.txtDeDepartmentName.Location = new System.Drawing.Point(133, 170);
            this.txtDeDepartmentName.MaxLength = 50;
            this.txtDeDepartmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeDepartmentName.Multiline = false;
            this.txtDeDepartmentName.Name = "txtDeDepartmentName";
            this.txtDeDepartmentName.Size = new System.Drawing.Size(221, 50);
            this.txtDeDepartmentName.TabIndex = 48;
            this.txtDeDepartmentName.Text = "";
            this.txtDeDepartmentName.TrailingIcon = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(328, 12);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(293, 41);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "CRUD Departments";
            // 
            // tpSalary
            // 
            this.tpSalary.Controls.Add(this.btnSaExportToPDF);
            this.tpSalary.Controls.Add(this.btnSaExportToExcel);
            this.tpSalary.Controls.Add(this.btnSaPrint);
            this.tpSalary.Controls.Add(this.btnSaShowMoSalary);
            this.tpSalary.Controls.Add(this.btnSaSearchById);
            this.tpSalary.Controls.Add(this.txtSaSearchEmpById);
            this.tpSalary.Controls.Add(this.pictureBox1);
            this.tpSalary.Controls.Add(this.dgvSaEmployees);
            this.tpSalary.Controls.Add(this.label12);
            this.tpSalary.Controls.Add(this.materialLabel6);
            this.tpSalary.ImageKey = "salary256.png";
            this.tpSalary.Location = new System.Drawing.Point(4, 31);
            this.tpSalary.Name = "tpSalary";
            this.tpSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tpSalary.Size = new System.Drawing.Size(986, 508);
            this.tpSalary.TabIndex = 6;
            this.tpSalary.Text = "Salary";
            this.tpSalary.UseVisualStyleBackColor = true;
            // 
            // btnSaExportToPDF
            // 
            this.btnSaExportToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaExportToPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaExportToPDF.Depth = 0;
            this.btnSaExportToPDF.HighEmphasis = true;
            this.btnSaExportToPDF.Icon = null;
            this.btnSaExportToPDF.Location = new System.Drawing.Point(190, 347);
            this.btnSaExportToPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaExportToPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaExportToPDF.Name = "btnSaExportToPDF";
            this.btnSaExportToPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaExportToPDF.Size = new System.Drawing.Size(130, 36);
            this.btnSaExportToPDF.TabIndex = 50;
            this.btnSaExportToPDF.Text = "Export To PDF";
            this.btnSaExportToPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaExportToPDF.UseAccentColor = false;
            this.btnSaExportToPDF.UseVisualStyleBackColor = true;
            this.btnSaExportToPDF.Click += new System.EventHandler(this.btnSaExportToPDF_Click);
            // 
            // btnSaExportToExcel
            // 
            this.btnSaExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaExportToExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaExportToExcel.Depth = 0;
            this.btnSaExportToExcel.HighEmphasis = true;
            this.btnSaExportToExcel.Icon = null;
            this.btnSaExportToExcel.Location = new System.Drawing.Point(17, 347);
            this.btnSaExportToExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaExportToExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaExportToExcel.Name = "btnSaExportToExcel";
            this.btnSaExportToExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaExportToExcel.Size = new System.Drawing.Size(147, 36);
            this.btnSaExportToExcel.TabIndex = 46;
            this.btnSaExportToExcel.Text = "Export To Excel";
            this.btnSaExportToExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaExportToExcel.UseAccentColor = false;
            this.btnSaExportToExcel.UseVisualStyleBackColor = true;
            this.btnSaExportToExcel.Click += new System.EventHandler(this.btnSaExportToExcel_Click);
            // 
            // btnSaPrint
            // 
            this.btnSaPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaPrint.Depth = 0;
            this.btnSaPrint.HighEmphasis = true;
            this.btnSaPrint.Icon = null;
            this.btnSaPrint.Location = new System.Drawing.Point(342, 347);
            this.btnSaPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaPrint.Name = "btnSaPrint";
            this.btnSaPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaPrint.Size = new System.Drawing.Size(64, 36);
            this.btnSaPrint.TabIndex = 45;
            this.btnSaPrint.Text = "Print";
            this.btnSaPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaPrint.UseAccentColor = false;
            this.btnSaPrint.UseVisualStyleBackColor = true;
            this.btnSaPrint.Click += new System.EventHandler(this.btnSaPrint_Click);
            // 
            // btnSaShowMoSalary
            // 
            this.btnSaShowMoSalary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaShowMoSalary.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaShowMoSalary.Depth = 0;
            this.btnSaShowMoSalary.HighEmphasis = true;
            this.btnSaShowMoSalary.Icon = null;
            this.btnSaShowMoSalary.Location = new System.Drawing.Point(459, 146);
            this.btnSaShowMoSalary.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaShowMoSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaShowMoSalary.Name = "btnSaShowMoSalary";
            this.btnSaShowMoSalary.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaShowMoSalary.Size = new System.Drawing.Size(195, 36);
            this.btnSaShowMoSalary.TabIndex = 44;
            this.btnSaShowMoSalary.Text = "Show Monthly Salary";
            this.btnSaShowMoSalary.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaShowMoSalary.UseAccentColor = false;
            this.btnSaShowMoSalary.UseVisualStyleBackColor = true;
            this.btnSaShowMoSalary.Click += new System.EventHandler(this.btnSaShowMoSalary_Click);
            // 
            // btnSaSearchById
            // 
            this.btnSaSearchById.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaSearchById.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaSearchById.Depth = 0;
            this.btnSaSearchById.HighEmphasis = true;
            this.btnSaSearchById.Icon = null;
            this.btnSaSearchById.Location = new System.Drawing.Point(361, 146);
            this.btnSaSearchById.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaSearchById.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaSearchById.Name = "btnSaSearchById";
            this.btnSaSearchById.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaSearchById.Size = new System.Drawing.Size(78, 36);
            this.btnSaSearchById.TabIndex = 43;
            this.btnSaSearchById.Text = "Search";
            this.btnSaSearchById.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaSearchById.UseAccentColor = false;
            this.btnSaSearchById.UseVisualStyleBackColor = true;
            this.btnSaSearchById.Click += new System.EventHandler(this.btnSaSearchById_Click);
            // 
            // txtSaSearchEmpById
            // 
            this.txtSaSearchEmpById.AnimateReadOnly = false;
            this.txtSaSearchEmpById.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaSearchEmpById.Depth = 0;
            this.txtSaSearchEmpById.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaSearchEmpById.LeadingIcon = null;
            this.txtSaSearchEmpById.Location = new System.Drawing.Point(111, 146);
            this.txtSaSearchEmpById.MaxLength = 50;
            this.txtSaSearchEmpById.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSaSearchEmpById.Multiline = false;
            this.txtSaSearchEmpById.Name = "txtSaSearchEmpById";
            this.txtSaSearchEmpById.Size = new System.Drawing.Size(221, 50);
            this.txtSaSearchEmpById.TabIndex = 30;
            this.txtSaSearchEmpById.Text = "";
            this.txtSaSearchEmpById.TrailingIcon = null;
            this.txtSaSearchEmpById.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaSearchEmpById_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformsDUCCompany1a.Properties.Resources.salary256;
            this.pictureBox1.Location = new System.Drawing.Point(419, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSaEmployees
            // 
            this.dgvSaEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.LateTimes,
            this.WorkingDays,
            this.Month,
            this.MonthlySalary});
            this.dgvSaEmployees.Location = new System.Drawing.Point(17, 214);
            this.dgvSaEmployees.Name = "dgvSaEmployees";
            this.dgvSaEmployees.Size = new System.Drawing.Size(878, 110);
            this.dgvSaEmployees.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Department Name ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PositionName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position Name ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DailySalary";
            this.dataGridViewTextBoxColumn8.HeaderText = "Daily Salary ($)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // LateTimes
            // 
            this.LateTimes.HeaderText = "Late Times";
            this.LateTimes.Name = "LateTimes";
            this.LateTimes.Width = 80;
            // 
            // WorkingDays
            // 
            this.WorkingDays.HeaderText = "Working Days";
            this.WorkingDays.Name = "WorkingDays";
            this.WorkingDays.Width = 80;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.Width = 60;
            // 
            // MonthlySalary
            // 
            this.MonthlySalary.HeaderText = "Monthly Salary ($)";
            this.MonthlySalary.Name = "MonthlySalary";
            this.MonthlySalary.Width = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Employee Id";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(395, 13);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(95, 41);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Salary";
            // 
            // tpProfile
            // 
            this.tpProfile.Controls.Add(this.pictureBox2);
            this.tpProfile.Controls.Add(this.LabelProRole);
            this.tpProfile.Controls.Add(this.LabelProEmail);
            this.tpProfile.Controls.Add(this.LabelProUsername);
            this.tpProfile.Controls.Add(this.materialLabel3);
            this.tpProfile.ImageKey = "user256.png";
            this.tpProfile.Location = new System.Drawing.Point(4, 31);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfile.Size = new System.Drawing.Size(986, 508);
            this.tpProfile.TabIndex = 5;
            this.tpProfile.Text = "Profile";
            this.tpProfile.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformsDUCCompany1a.Properties.Resources.user256;
            this.pictureBox2.Location = new System.Drawing.Point(452, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // LabelProRole
            // 
            this.LabelProRole.AutoSize = true;
            this.LabelProRole.Location = new System.Drawing.Point(30, 203);
            this.LabelProRole.Name = "LabelProRole";
            this.LabelProRole.Size = new System.Drawing.Size(38, 13);
            this.LabelProRole.TabIndex = 29;
            this.LabelProRole.Text = "Role : ";
            // 
            // LabelProEmail
            // 
            this.LabelProEmail.AutoSize = true;
            this.LabelProEmail.Location = new System.Drawing.Point(30, 171);
            this.LabelProEmail.Name = "LabelProEmail";
            this.LabelProEmail.Size = new System.Drawing.Size(41, 13);
            this.LabelProEmail.TabIndex = 28;
            this.LabelProEmail.Text = "Email : ";
            // 
            // LabelProUsername
            // 
            this.LabelProUsername.AutoSize = true;
            this.LabelProUsername.Location = new System.Drawing.Point(30, 142);
            this.LabelProUsername.Name = "LabelProUsername";
            this.LabelProUsername.Size = new System.Drawing.Size(64, 13);
            this.LabelProUsername.TabIndex = 27;
            this.LabelProUsername.Text = "Username : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(429, 18);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 41);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Profile";
            // 
            // tpCRUD
            // 
            this.tpCRUD.Controls.Add(this.btnResetEmp);
            this.tpCRUD.Controls.Add(this.btnDeleteEmp);
            this.tpCRUD.Controls.Add(this.btnSaveEmp);
            this.tpCRUD.Controls.Add(this.btnClearEmpPhoto);
            this.tpCRUD.Controls.Add(this.btnUploadEmpPhoto);
            this.tpCRUD.Controls.Add(this.txtEmpAddress);
            this.tpCRUD.Controls.Add(this.txtEmpName);
            this.tpCRUD.Controls.Add(this.cmbEmpPosition);
            this.tpCRUD.Controls.Add(this.label6);
            this.tpCRUD.Controls.Add(this.cmbEmpDepartment);
            this.tpCRUD.Controls.Add(this.label5);
            this.tpCRUD.Controls.Add(this.label4);
            this.tpCRUD.Controls.Add(this.cmbEmpGender);
            this.tpCRUD.Controls.Add(this.label3);
            this.tpCRUD.Controls.Add(this.label2);
            this.tpCRUD.Controls.Add(this.dtpEmpDOB);
            this.tpCRUD.Controls.Add(this.label1);
            this.tpCRUD.Controls.Add(this.materialLabel1);
            this.tpCRUD.Controls.Add(this.pbEmpPhoto);
            this.tpCRUD.ImageKey = "group_people256.png";
            this.tpCRUD.Location = new System.Drawing.Point(4, 31);
            this.tpCRUD.Name = "tpCRUD";
            this.tpCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.tpCRUD.Size = new System.Drawing.Size(986, 508);
            this.tpCRUD.TabIndex = 3;
            this.tpCRUD.Text = "CRUD";
            this.tpCRUD.UseVisualStyleBackColor = true;
            // 
            // btnResetEmp
            // 
            this.btnResetEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetEmp.Depth = 0;
            this.btnResetEmp.HighEmphasis = true;
            this.btnResetEmp.Icon = null;
            this.btnResetEmp.Location = new System.Drawing.Point(210, 379);
            this.btnResetEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetEmp.Name = "btnResetEmp";
            this.btnResetEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetEmp.Size = new System.Drawing.Size(65, 36);
            this.btnResetEmp.TabIndex = 42;
            this.btnResetEmp.Text = "Reset";
            this.btnResetEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetEmp.UseAccentColor = false;
            this.btnResetEmp.UseVisualStyleBackColor = true;
            this.btnResetEmp.Click += new System.EventHandler(this.btnResetEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteEmp.Depth = 0;
            this.btnDeleteEmp.HighEmphasis = true;
            this.btnDeleteEmp.Icon = null;
            this.btnDeleteEmp.Location = new System.Drawing.Point(110, 379);
            this.btnDeleteEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteEmp.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteEmp.TabIndex = 41;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteEmp.UseAccentColor = false;
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveEmp.Depth = 0;
            this.btnSaveEmp.HighEmphasis = true;
            this.btnSaveEmp.Icon = null;
            this.btnSaveEmp.Location = new System.Drawing.Point(21, 379);
            this.btnSaveEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveEmp.Size = new System.Drawing.Size(64, 36);
            this.btnSaveEmp.TabIndex = 40;
            this.btnSaveEmp.Text = "Save";
            this.btnSaveEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveEmp.UseAccentColor = false;
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            this.btnSaveEmp.Click += new System.EventHandler(this.btnSaveEmp_Click);
            // 
            // btnClearEmpPhoto
            // 
            this.btnClearEmpPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearEmpPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearEmpPhoto.Depth = 0;
            this.btnClearEmpPhoto.HighEmphasis = true;
            this.btnClearEmpPhoto.Icon = null;
            this.btnClearEmpPhoto.Location = new System.Drawing.Point(496, 232);
            this.btnClearEmpPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearEmpPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearEmpPhoto.Name = "btnClearEmpPhoto";
            this.btnClearEmpPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearEmpPhoto.Size = new System.Drawing.Size(66, 36);
            this.btnClearEmpPhoto.TabIndex = 39;
            this.btnClearEmpPhoto.Text = "Clear";
            this.btnClearEmpPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearEmpPhoto.UseAccentColor = false;
            this.btnClearEmpPhoto.UseVisualStyleBackColor = true;
            this.btnClearEmpPhoto.Click += new System.EventHandler(this.btnClearEmpPhoto_Click);
            // 
            // btnUploadEmpPhoto
            // 
            this.btnUploadEmpPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadEmpPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUploadEmpPhoto.Depth = 0;
            this.btnUploadEmpPhoto.HighEmphasis = true;
            this.btnUploadEmpPhoto.Icon = null;
            this.btnUploadEmpPhoto.Location = new System.Drawing.Point(410, 232);
            this.btnUploadEmpPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadEmpPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadEmpPhoto.Name = "btnUploadEmpPhoto";
            this.btnUploadEmpPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUploadEmpPhoto.Size = new System.Drawing.Size(78, 36);
            this.btnUploadEmpPhoto.TabIndex = 38;
            this.btnUploadEmpPhoto.Text = "Upload";
            this.btnUploadEmpPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUploadEmpPhoto.UseAccentColor = false;
            this.btnUploadEmpPhoto.UseVisualStyleBackColor = true;
            this.btnUploadEmpPhoto.Click += new System.EventHandler(this.btnUploadEmpPhoto_Click);
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpAddress.Depth = 0;
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmpAddress.Location = new System.Drawing.Point(141, 193);
            this.txtEmpAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(221, 50);
            this.txtEmpAddress.TabIndex = 32;
            this.txtEmpAddress.Text = "";
            // 
            // txtEmpName
            // 
            this.txtEmpName.AnimateReadOnly = false;
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpName.Depth = 0;
            this.txtEmpName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.LeadingIcon = null;
            this.txtEmpName.Location = new System.Drawing.Point(141, 56);
            this.txtEmpName.MaxLength = 50;
            this.txtEmpName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpName.Multiline = false;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(221, 50);
            this.txtEmpName.TabIndex = 25;
            this.txtEmpName.Text = "";
            this.txtEmpName.TrailingIcon = null;
            // 
            // cmbEmpPosition
            // 
            this.cmbEmpPosition.AutoResize = false;
            this.cmbEmpPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpPosition.Depth = 0;
            this.cmbEmpPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpPosition.DropDownHeight = 174;
            this.cmbEmpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpPosition.DropDownWidth = 121;
            this.cmbEmpPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpPosition.FormattingEnabled = true;
            this.cmbEmpPosition.IntegralHeight = false;
            this.cmbEmpPosition.ItemHeight = 43;
            this.cmbEmpPosition.Location = new System.Drawing.Point(141, 310);
            this.cmbEmpPosition.MaxDropDownItems = 4;
            this.cmbEmpPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpPosition.Name = "cmbEmpPosition";
            this.cmbEmpPosition.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpPosition.StartIndex = 0;
            this.cmbEmpPosition.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Position";
            // 
            // cmbEmpDepartment
            // 
            this.cmbEmpDepartment.AutoResize = false;
            this.cmbEmpDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpDepartment.Depth = 0;
            this.cmbEmpDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpDepartment.DropDownHeight = 174;
            this.cmbEmpDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpDepartment.DropDownWidth = 121;
            this.cmbEmpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpDepartment.FormattingEnabled = true;
            this.cmbEmpDepartment.IntegralHeight = false;
            this.cmbEmpDepartment.ItemHeight = 43;
            this.cmbEmpDepartment.Location = new System.Drawing.Point(141, 255);
            this.cmbEmpDepartment.MaxDropDownItems = 4;
            this.cmbEmpDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpDepartment.Name = "cmbEmpDepartment";
            this.cmbEmpDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpDepartment.StartIndex = 0;
            this.cmbEmpDepartment.TabIndex = 34;
            this.cmbEmpDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbEmpDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // cmbEmpGender
            // 
            this.cmbEmpGender.AutoResize = false;
            this.cmbEmpGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpGender.Depth = 0;
            this.cmbEmpGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpGender.DropDownHeight = 174;
            this.cmbEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpGender.DropDownWidth = 121;
            this.cmbEmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpGender.FormattingEnabled = true;
            this.cmbEmpGender.IntegralHeight = false;
            this.cmbEmpGender.ItemHeight = 43;
            this.cmbEmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEmpGender.Location = new System.Drawing.Point(141, 138);
            this.cmbEmpGender.MaxDropDownItems = 4;
            this.cmbEmpGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpGender.Name = "cmbEmpGender";
            this.cmbEmpGender.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpGender.StartIndex = 0;
            this.cmbEmpGender.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date of birth";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Location = new System.Drawing.Point(141, 112);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(221, 20);
            this.dtpEmpDOB.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(336, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(242, 41);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "CRUD Emloyees";
            // 
            // pbEmpPhoto
            // 
            this.pbEmpPhoto.Location = new System.Drawing.Point(410, 56);
            this.pbEmpPhoto.Name = "pbEmpPhoto";
            this.pbEmpPhoto.Size = new System.Drawing.Size(150, 150);
            this.pbEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpPhoto.TabIndex = 37;
            this.pbEmpPhoto.TabStop = false;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.btnShowAll);
            this.tpHome.Controls.Add(this.btnFilter);
            this.tpHome.Controls.Add(this.btnExportToPDF);
            this.tpHome.Controls.Add(this.btnExportToExcel);
            this.tpHome.Controls.Add(this.btnPrint);
            this.tpHome.Controls.Add(this.txtSearchEmpByName);
            this.tpHome.Controls.Add(this.cmbHomeDepartment);
            this.tpHome.Controls.Add(this.label13);
            this.tpHome.Controls.Add(this.label11);
            this.tpHome.Controls.Add(this.materialLabel2);
            this.tpHome.Controls.Add(this.dgvEmployees);
            this.tpHome.ImageKey = "home256.png";
            this.tpHome.Location = new System.Drawing.Point(4, 31);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(986, 508);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowAll.Depth = 0;
            this.btnShowAll.HighEmphasis = true;
            this.btnShowAll.Icon = null;
            this.btnShowAll.Location = new System.Drawing.Point(822, 81);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowAll.Size = new System.Drawing.Size(93, 36);
            this.btnShowAll.TabIndex = 53;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowAll.UseAccentColor = false;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(740, 81);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 52;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportToPDF.Depth = 0;
            this.btnExportToPDF.HighEmphasis = true;
            this.btnExportToPDF.Icon = null;
            this.btnExportToPDF.Location = new System.Drawing.Point(206, 434);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportToPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportToPDF.Size = new System.Drawing.Size(130, 36);
            this.btnExportToPDF.TabIndex = 49;
            this.btnExportToPDF.Text = "Export To PDF";
            this.btnExportToPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportToPDF.UseAccentColor = false;
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportToExcel.Depth = 0;
            this.btnExportToExcel.HighEmphasis = true;
            this.btnExportToExcel.Icon = null;
            this.btnExportToExcel.Location = new System.Drawing.Point(37, 434);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportToExcel.Size = new System.Drawing.Size(147, 36);
            this.btnExportToExcel.TabIndex = 48;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportToExcel.UseAccentColor = false;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(363, 434);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(64, 36);
            this.btnPrint.TabIndex = 47;
            this.btnPrint.Text = "Print";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearchEmpByName
            // 
            this.txtSearchEmpByName.AnimateReadOnly = false;
            this.txtSearchEmpByName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchEmpByName.Depth = 0;
            this.txtSearchEmpByName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEmpByName.LeadingIcon = null;
            this.txtSearchEmpByName.Location = new System.Drawing.Point(161, 81);
            this.txtSearchEmpByName.MaxLength = 50;
            this.txtSearchEmpByName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchEmpByName.Multiline = false;
            this.txtSearchEmpByName.Name = "txtSearchEmpByName";
            this.txtSearchEmpByName.Size = new System.Drawing.Size(175, 50);
            this.txtSearchEmpByName.TabIndex = 27;
            this.txtSearchEmpByName.Text = "";
            this.txtSearchEmpByName.TrailingIcon = null;
            this.txtSearchEmpByName.TextChanged += new System.EventHandler(this.txtSearchEmpByName_TextChanged);
            this.txtSearchEmpByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEmpByName_KeyPress);
            // 
            // cmbHomeDepartment
            // 
            this.cmbHomeDepartment.AutoResize = false;
            this.cmbHomeDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHomeDepartment.Depth = 0;
            this.cmbHomeDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHomeDepartment.DropDownHeight = 174;
            this.cmbHomeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeDepartment.DropDownWidth = 121;
            this.cmbHomeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHomeDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHomeDepartment.FormattingEnabled = true;
            this.cmbHomeDepartment.IntegralHeight = false;
            this.cmbHomeDepartment.ItemHeight = 43;
            this.cmbHomeDepartment.Location = new System.Drawing.Point(512, 81);
            this.cmbHomeDepartment.MaxDropDownItems = 4;
            this.cmbHomeDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHomeDepartment.Name = "cmbHomeDepartment";
            this.cmbHomeDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbHomeDepartment.StartIndex = 0;
            this.cmbHomeDepartment.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Filter  by department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Search  by name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(367, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 41);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Emloyees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpDOB,
            this.EmpGender,
            this.EmpAddress,
            this.DepartmentName,
            this.PositionName,
            this.DailySalary});
            this.dgvEmployees.Location = new System.Drawing.Point(37, 136);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(878, 274);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.DoubleClick += new System.EventHandler(this.dgvEmployees_DoubleClick);
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "Id ";
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 30;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Name ";
            this.EmpName.Name = "EmpName";
            // 
            // EmpDOB
            // 
            this.EmpDOB.DataPropertyName = "EmpDOB";
            this.EmpDOB.HeaderText = "Date of birth";
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Width = 90;
            // 
            // EmpGender
            // 
            this.EmpGender.DataPropertyName = "EmpGender";
            this.EmpGender.HeaderText = "Gender ";
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Width = 80;
            // 
            // EmpAddress
            // 
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Address ";
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Width = 200;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department Name ";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 120;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "Position Name ";
            this.PositionName.Name = "PositionName";
            this.PositionName.Width = 150;
            // 
            // DailySalary
            // 
            this.DailySalary.DataPropertyName = "DailySalary";
            this.DailySalary.HeaderText = "Daily Salary ($)";
            this.DailySalary.Name = "DailySalary";
            this.DailySalary.Width = 50;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpHome);
            this.materialTabControl1.Controls.Add(this.tpCRUD);
            this.materialTabControl1.Controls.Add(this.tpProfile);
            this.materialTabControl1.Controls.Add(this.tpSalary);
            this.materialTabControl1.Controls.Add(this.tpDapartment);
            this.materialTabControl1.Controls.Add(this.tpPosition);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 543);
            this.materialTabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainForm";
            this.Text = "DUC COMPANY";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tpPosition.ResumeLayout(false);
            this.tpPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.tpDapartment.ResumeLayout(false);
            this.tpDapartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tpSalary.ResumeLayout(false);
            this.tpSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaEmployees)).EndInit();
            this.tpProfile.ResumeLayout(false);
            this.tpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpCRUD.ResumeLayout(false);
            this.tpCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpPhoto)).EndInit();
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.TabPage tpPosition;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoPositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoDailySalary;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtPoDailySalary;
        private MaterialSkin.Controls.MaterialButton btnResetPo;
        private MaterialSkin.Controls.MaterialButton btnDeletePo;
        private MaterialSkin.Controls.MaterialButton btnSavePo;
        private MaterialSkin.Controls.MaterialTextBox txtPoPositionName;
        private MaterialSkin.Controls.MaterialComboBox cmbPoDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TabPage tpDapartment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeDepartmentName;
        private MaterialSkin.Controls.MaterialButton btnResetDe;
        private MaterialSkin.Controls.MaterialButton btnDeleteDe;
        private MaterialSkin.Controls.MaterialButton btnSaveDe;
        private MaterialSkin.Controls.MaterialTextBox txtDeDepartmentName;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TabPage tpSalary;
        private MaterialSkin.Controls.MaterialButton btnSaExportToPDF;
        private MaterialSkin.Controls.MaterialButton btnSaExportToExcel;
        private MaterialSkin.Controls.MaterialButton btnSaPrint;
        private MaterialSkin.Controls.MaterialButton btnSaShowMoSalary;
        private MaterialSkin.Controls.MaterialButton btnSaSearchById;
        private MaterialSkin.Controls.MaterialTextBox txtSaSearchEmpById;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSaEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalary;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelProRole;
        private System.Windows.Forms.Label LabelProEmail;
        private System.Windows.Forms.Label LabelProUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage tpCRUD;
        private MaterialSkin.Controls.MaterialButton btnResetEmp;
        private MaterialSkin.Controls.MaterialButton btnDeleteEmp;
        private MaterialSkin.Controls.MaterialButton btnSaveEmp;
        private MaterialSkin.Controls.MaterialButton btnClearEmpPhoto;
        private MaterialSkin.Controls.MaterialButton btnUploadEmpPhoto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtEmpAddress;
        private MaterialSkin.Controls.MaterialTextBox txtEmpName;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpPosition;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbEmpPhoto;
        private System.Windows.Forms.TabPage tpHome;
        private MaterialSkin.Controls.MaterialButton btnShowAll;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private MaterialSkin.Controls.MaterialButton btnExportToPDF;
        private MaterialSkin.Controls.MaterialButton btnExportToExcel;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialTextBox txtSearchEmpByName;
        private MaterialSkin.Controls.MaterialComboBox cmbHomeDepartment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailySalary;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    }
}