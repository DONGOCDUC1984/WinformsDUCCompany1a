﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tulpep.NotificationWindow;

namespace WinformsDUCCompany1a.Forms
{
    public partial class MainForm :  MaterialForm
    {
        int DepartmentId = 0;
        bool isDefaultImage = true;
        string previousImageString = "";
        OpenFileDialog ofd = new OpenFileDialog();
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; } = "";
        Employee employee = new Employee();
        Department department = new Department();
        Position position = new Position();

        readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.DeepOrange400, Primary.DeepOrange600, Primary.Indigo100,
                Accent.DeepOrange700, TextShade.WHITE);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearEmp();
            ClearDe();
            ClearPo();
            FillAllComboBoxes();
            ForAdmin();
            FillProfile();
            FillAllDataGridViews();
        }
        // Fill All ComboBoxes
        private void FillAllComboBoxes()
        {
            FillcmbEmpDepartment();
            FillcmbHomeDepartment();
            FillcmbPoDepartment();
        }
        // Fill All DataGridViews
        private void FillAllDataGridViews()
        {
            FilldgvEmployees();
            FilldgvDepartments();
            FilldgvPositions();
        }
        // Reset Employees
        private void btnResetEmp_Click(object sender, EventArgs e)
        {
            ClearEmp();
        }
        // Clear Employees
        private void ClearEmp()
        {
            txtEmpName.Clear();
            dtpEmpDOB.Value = DateTime.Now;
            if (cmbEmpGender.DataSource != null)
            {
                //cmbEmpGender.Text = "";
                cmbEmpGender.SelectedIndex = 0;
            }
            txtEmpAddress.Clear();
            if (cmbEmpDepartment.DataSource != null)
            {
                cmbEmpDepartment.SelectedIndex = 0;
            }
            if (cmbEmpPosition.DataSource != null)
            {
                cmbEmpPosition.SelectedIndex = 0;
            }

            employee.EmpId = 0;
            pbEmpPhoto.Image = System.Drawing.Image
                .FromFile(Application.StartupPath + "\\Images\\user256.png");
            isDefaultImage = true;
            btnSaveEmp.Text = "Save";
            // To disable Delete button
            btnDeleteEmp.Enabled = false;
            
            
        }

        // Show Popup notification
        private void ShowPopUpNoti(string s)
        {
            PopupNotifier popupNotifier = new PopupNotifier();
            popupNotifier.Image = Properties.Resources.information64;
            popupNotifier.TitleText = "Message";
            popupNotifier.ContentText = s;
            popupNotifier.Popup();
        }
        // For Admin
        private void ForAdmin()
        {
            // is Admin
            if (UserRole == "Admin")
            {
                btnSaveEmp.Show();
                btnDeleteEmp.Show();
                btnUploadEmpPhoto.Show();
                btnClearEmpPhoto.Show();
                btnSaveDe.Show();
                btnDeleteDe.Show();
                dgvDepartments.Show();
                btnSavePo.Show();
                btnDeletePo.Show();
            }
            // is not Admin
            else
            {
                btnSaveEmp.Hide();
                btnDeleteEmp.Hide();
                btnUploadEmpPhoto.Hide();
                btnClearEmpPhoto.Hide();
                btnSaveDe.Hide();
                btnDeleteDe.Hide();
                dgvDepartments.Hide();
                btnSavePo.Hide();
                btnDeletePo.Hide();
            }
        }
        private void FillcmbHomeDepartment()
        {
            // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
            cmbHomeDepartment.ValueMember = "DepartmentId";
            cmbHomeDepartment.DisplayMember = "DepartmentName";

            using (DBEntities db = new DBEntities())
            {
                cmbHomeDepartment.DataSource = db.Departments.ToList<Department>();
            }

        }
        private void FillcmbEmpDepartment()
        {
            // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
            cmbEmpDepartment.ValueMember = "DepartmentId";
            cmbEmpDepartment.DisplayMember = "DepartmentName";

            using (DBEntities db = new DBEntities())
            {
                cmbEmpDepartment.DataSource = db.Departments.ToList<Department>();
            }

        }

         // Cascading dropdown
        private void FillcmbEmpPosition(int DepartmentId)
        {
            // In the 2 following lines,"PositionId" and "PositionName" are from Positions table
            cmbEmpPosition.ValueMember = "PositionId";
            cmbEmpPosition.DisplayMember = "PositionName";

            using (DBEntities db = new DBEntities())
            {
                cmbEmpPosition.DataSource = db.Positions
                    .Where(x => x.DepartmentId == DepartmentId)
                    .ToList<Position>();
                    
            }

        }
        // Cascading dropdown
        private void cmbEmpDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpDepartment.SelectedValue != null)
            {
                DepartmentId = Convert.ToInt32(cmbEmpDepartment.SelectedValue);
                FillcmbEmpPosition(DepartmentId);
            }
        }

        private void btnUploadEmpPhoto_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbEmpPhoto.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                previousImageString = "";
            }
        }

        private void btnClearEmpPhoto_Click(object sender, EventArgs e)
        {
            pbEmpPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\user256.png");
            isDefaultImage = true;
            previousImageString = "";
        }
        // Check form of employees
        private bool checkFormEmp()
        {
            if (txtEmpName.Text == "" || txtEmpAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                   "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private string saveImage(string _imagePath)
        {
            string _fileName = Path.GetFileNameWithoutExtension(_imagePath);
            string _extension = Path.GetExtension(_imagePath);
            // shorten image Name
            _fileName = _fileName.Length <= 15 ? _fileName : _fileName.Substring(0, 15);
            _fileName = _fileName + DateTime.Now.ToString("yymmssfff") + _extension;
            pbEmpPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
            return _fileName;
        }
        private void FilldgvEmployees()
        {
            txtSearchEmpByName.Clear();
            dgvEmployees.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvEmployees.DataSource
                    = (from emp in db.Employees
                       join depa in db.Departments
                       on emp.DepartmentId equals depa.DepartmentId
                       join posi in db.Positions
                       on emp.PositionId equals posi.PositionId
                       select new 
                       {
                            emp.EmpId,
                            emp.EmpName,
                            emp.EmpDOB,
                            emp.EmpGender,
                            // emp.EmpImagePath,
                            emp.EmpAddress,
                            depa.DepartmentName,
                            posi.PositionName,
                            posi.DailySalary
                       }).ToList();
                //dgvEmployees.DataSource=(from emp in db.Employees
                //                         select emp
                //                         )
                //                         .Include(x=>x.Department)
                //                         .Include(x=>x.Position)
                //                         .ToList<Employee>();

            }
        }
        // Save Employee
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            if (checkFormEmp())
            {
                employee.EmpName = txtEmpName.Text.Trim();
                employee.EmpDOB = dtpEmpDOB.Value;
                employee.EmpGender = cmbEmpGender.Text.Trim();
                employee.EmpAddress = txtEmpAddress.Text.Trim();
                employee.DepartmentId = Convert.ToInt32(cmbEmpDepartment.SelectedValue);
                employee.PositionId = Convert.ToInt32(cmbEmpPosition.SelectedValue) ;
                // Create
                if (employee.EmpId == 0)
                {
                    if (isDefaultImage)
                    {
                        employee.EmpImagePath = null;
                    }
                    else
                    {
                        employee.EmpImagePath = saveImage(ofd.FileName);
                    }
                }
                // Update
                else
                {
                    if (isDefaultImage)
                    {
                        employee.EmpImagePath = null;
                    }
                    else
                    {
                        if (previousImageString != "")
                        {
                            employee.EmpImagePath = previousImageString;
                        }
                        else
                        {
                            employee.EmpImagePath = saveImage(ofd.FileName);
                        }
                    }
                }
                using (DBEntities db = new DBEntities())
                {
                    // Create
                    if (employee.EmpId == 0)
                    {
                        db.Employees.Add(employee);
                    }
                    // Update
                    else
                    {
                        db.Employees.AddOrUpdate(employee);
                        // The above line is equivalent to the following line
                        // db.Entry(model).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearEmp();
                FilldgvEmployees();
                ShowPopUpNoti("Successfully saved");
            }
        }
        //Delete Employee
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
               "EF CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(employee);
                    if (db.Entry(employee).State == EntityState.Detached)
                    {
                        db.Employees.Attach(employee);
                    }
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    ClearEmp();
                    FilldgvEmployees();
                    ShowPopUpNoti("Successfully deleted");
                }
            }
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                employee.EmpId = Convert.ToInt32(dgvEmployees
                    .CurrentRow.Cells[0].Value);
            }
            using (DBEntities db = new DBEntities())
            {
                employee = db.Employees.Where(x => x.EmpId == employee.EmpId)
                      .FirstOrDefault();
                txtEmpName.Text = employee.EmpName;
                dtpEmpDOB.Value = employee.EmpDOB;
                cmbEmpGender.Text = employee.EmpGender;
                if (employee.EmpImagePath == null)
                {
                    pbEmpPhoto.Image = System.Drawing.Image
                        .FromFile(Application.StartupPath + "\\Images\\user256.png");
                    // The 2 above lines are equivalent to the 2 following lines
                    //pbEmpPhoto.Image =
                    //    new Bitmap (Application.StartupPath + "\\Images\\user256.png");
                    isDefaultImage = true;
                }
                else
                {
                    pbEmpPhoto.Image = System.Drawing.Image
                        .FromFile(Application.StartupPath + "\\Images\\"
                   + employee.EmpImagePath);
                    isDefaultImage = false;
                    previousImageString = employee.EmpImagePath;
                }
                txtEmpAddress.Text = employee.EmpAddress;
                cmbEmpDepartment.SelectedValue = employee.DepartmentId;
                cmbEmpPosition.SelectedValue = employee.PositionId;
            }
            btnSaveEmp.Text = "Update";
            btnDeleteEmp.Enabled = true;
        }
        // txtSearchEmpByName only accepts letters and space
        private void txtSearchEmpByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = true;
            }
        }

        // Search employee by name
        private void txtSearchEmpByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmpByName.Text !="")
            {
                dgvEmployees.AutoGenerateColumns = false;
                using (DBEntities db = new DBEntities())
                {
                    dgvEmployees.DataSource
                        = (from emp in db.Employees
                           where emp.EmpName.Contains(txtSearchEmpByName.Text.Trim())
                           join depa in db.Departments
                           on emp.DepartmentId equals depa.DepartmentId
                           join posi in db.Positions
                           on emp.PositionId equals posi.PositionId
                           select new
                           {
                               emp.EmpId,
                               emp.EmpName,
                               emp.EmpDOB,
                               emp.EmpGender,
                               // emp.EmpImagePath,
                               emp.EmpAddress,
                               depa.DepartmentName,
                               posi.PositionName,
                               posi.DailySalary
                           }).ToList();
                }

            }
            else
            {
                FilldgvEmployees();
            }
        }
        // Filter Employees by Department
        private void btnFilter_Click(object sender, EventArgs e)
        {
            txtSearchEmpByName.Clear();
            dgvEmployees.AutoGenerateColumns = false;
            int HomeDepartmentId 
                = Convert.ToInt32(cmbHomeDepartment.SelectedValue);
            using (DBEntities db = new DBEntities())
            {
                dgvEmployees.DataSource
                    = (from emp in db.Employees
                       where emp.DepartmentId
                         == HomeDepartmentId 
                       join depa in db.Departments
                       on emp.DepartmentId equals depa.DepartmentId
                       join posi in db.Positions
                       on emp.PositionId equals posi.PositionId
                       select new
                       {
                           emp.EmpId,
                           emp.EmpName,
                           emp.EmpDOB,
                           emp.EmpGender,
                           // emp.EmpImagePath,
                           emp.EmpAddress,
                           depa.DepartmentName,
                           posi.PositionName,
                           posi.DailySalary
                       }).ToList();
            }
        }
        // Show all employees
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FilldgvEmployees();
        }
        // Export to Excel file
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel;
                    Microsoft.Office.Interop.Excel.Workbook workbook;
                    Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    try
                    {
                        // Create a COM object
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = false;
                        excel.DisplayAlerts = false;
                        // Create a workbook by add()
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook
                            .Sheets["Sheet1"];
                        worksheet.Name = "Employee Management";
                        //Export header from Datagridview
                        for (int i = 0; i < dgvEmployees.ColumnCount; i++)
                        {
                            worksheet.Cells[1, i + 1] = dgvEmployees.Columns[i].HeaderText;
                        }
                        //Export content from Datagridview
                        for (int i = 0; i < dgvEmployees.RowCount; i++)
                        {
                            for (int j = 0; j < dgvEmployees.ColumnCount; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvEmployees.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        // Save
                        workbook.SaveAs(sfd.FileName);
                        workbook.Close();
                        excel.Quit();
                        ShowPopUpNoti("Exported to Excel successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        workbook = null;
                        worksheet = null;
                    }
                }
            }
        }
        // Export to PDF file
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; ;
                sfd.FileName = "PDFResult.pdf";
                bool ErrorMessage = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show
                                ("Unable to save " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdfPTable =
                                new PdfPTable(dgvEmployees.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 2;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvEmployees.Columns)
                            {
                                PdfPCell pdfPCell =
                                    new PdfPCell(new Phrase(col.HeaderText));
                                pdfPTable.AddCell(pdfPCell);
                            }
                            foreach (DataGridViewRow row in dgvEmployees.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value?.ToString());
                                }
                            }


                            using (FileStream fileStream =
                                new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document document =
                                    new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pdfPTable);
                                document.Close();
                                fileStream.Close();
                            }
                            ShowPopUpNoti("Exported to PDF successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show
                                ("Error while exporting: " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap
               (dgvEmployees.Width, dgvEmployees.Height);
            dgvEmployees.DrawToBitmap(bitmap,
                new System.Drawing.Rectangle(0, 0, dgvEmployees.Width, dgvEmployees.Height));
            e.Graphics.DrawImage(bitmap, 80, 150);
            // Print Header
            e.Graphics.DrawString("Employees",
                new System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black,
                new Point(50, 50));
        }
        // Print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void FillProfile()
        {
            LabelProUsername.Text += UserName;
            LabelProEmail.Text += UserEmail;
            LabelProRole.Text += UserRole;
        }

        // TapPage Salary
        // txtSaSearchEmpById only accepts numbers
        private void txtSaSearchEmpById_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Search employee by Id
        private void btnSaSearchById_Click(object sender, EventArgs e)
        {
            dgvSaEmployees.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                int searchId = Convert.ToInt32(txtSaSearchEmpById.Text.Trim());
                dgvSaEmployees.DataSource
                    = (from emp in db.Employees
                       where emp.EmpId == searchId
                       //where emp.EmpId == 2
                       join depa in db.Departments
                       on emp.DepartmentId equals depa.DepartmentId
                       join posi in db.Positions
                       on emp.PositionId equals posi.PositionId
                       select new
                       {
                           emp.EmpId,
                           emp.EmpName,
                           //emp.EmpDOB,
                           //emp.EmpGender,
                           //emp.EmpImagePath,
                           //emp.EmpAddress,
                           depa.DepartmentName,
                           posi.PositionName,
                           posi.DailySalary
                       }).ToList();
            }
        }

        // Show Monthly Salary
        private void btnSaShowMoSalary_Click(object sender, EventArgs e)
        {
            var dailySalary
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[4].Value);
            var lateTimes
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[5].Value);
            var workingDays
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[6].Value);
            var monthlySalary
               = dailySalary * workingDays - lateTimes * 2;
            dgvSaEmployees.Rows[0].Cells[8].Value = monthlySalary;

        }
        // Export to Excel file
        private void btnSaExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel;
                    Microsoft.Office.Interop.Excel.Workbook workbook;
                    Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    try
                    {
                        // Create a COM object
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = false;
                        excel.DisplayAlerts = false;
                        // Create a workbook by add()
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook
                            .Sheets["Sheet1"];
                        worksheet.Name = "Salary";
                        //Export header from Datagridview
                        for (int i = 0; i < dgvSaEmployees.ColumnCount; i++)
                        {
                            worksheet.Cells[1, i + 1] = dgvSaEmployees.Columns[i].HeaderText;
                        }
                        //Export content from Datagridview
                        for (int i = 0; i < dgvSaEmployees.RowCount; i++)
                        {
                            for (int j = 0; j < dgvSaEmployees.ColumnCount; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvSaEmployees.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        // Save
                        workbook.SaveAs(sfd.FileName);
                        workbook.Close();
                        excel.Quit();
                        ShowPopUpNoti("Exported to Excel successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        workbook = null;
                        worksheet = null;
                    }
                }
            }
        }

        // Export to PDF file
        private void btnSaExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgvSaEmployees.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; ;
                sfd.FileName = "PDFResult.pdf";
                bool ErrorMessage = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show
                                ("Unable to save " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdfPTable =
                                new PdfPTable(dgvSaEmployees.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 2;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvSaEmployees.Columns)
                            {
                                PdfPCell pdfPCell =
                                    new PdfPCell(new Phrase(col.HeaderText));
                                pdfPTable.AddCell(pdfPCell);
                            }
                            foreach (DataGridViewRow row in dgvSaEmployees.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value?.ToString());
                                }
                            }


                            using (FileStream fileStream =
                                new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document document =
                                    new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pdfPTable);
                                document.Close();
                                fileStream.Close();
                            }
                            ShowPopUpNoti("Exported to PDF successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show
                                ("Error while exporting: " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap
               (dgvSaEmployees.Width, dgvSaEmployees.Height);
            dgvSaEmployees.DrawToBitmap(bitmap,
                new System.Drawing.Rectangle(0, 0, dgvSaEmployees.Width, dgvSaEmployees.Height));
            e.Graphics.DrawImage(bitmap, 60, 200);
            // Print Header
            e.Graphics.DrawString("Salary",
                new System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black,
                new Point(50, 50));
        }
        // Print
        private void btnSaPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }
        
        // TapPage Department
        // CRUD Departments
        // Save Department
        private void btnSaveDe_Click(object sender, EventArgs e)
        {
            if (txtDeDepartmentName.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                department.DepartmentName = txtDeDepartmentName.Text.Trim();

                using (DBEntities db = new DBEntities())
                {
                    // Create
                    if (department.DepartmentId == 0)
                    {
                        db.Departments.Add(department);
                    }
                    // Update
                    else
                    {
                        db.Departments.AddOrUpdate(department);
                        // The above line is equivalent to the following line
                        // db.Entry(model).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearDe();
                FillAllComboBoxes();
                FillAllDataGridViews();
                ShowPopUpNoti("Successfully saved");
            }
        }
        // Delete Department
        private void btnDeleteDe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
                "EF CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(department);
                    if (db.Entry(department).State == EntityState.Detached)
                    {
                        db.Departments.Attach(department);
                    }
                    db.Departments.Remove(department);
                    db.SaveChanges();
                    ClearDe();
                    FillAllComboBoxes();
                    FillAllDataGridViews();
                    ShowPopUpNoti("Successfully deleted");
                }
            }
        }
        // Reset Department
        private void btnResetDe_Click(object sender, EventArgs e)
        {
            ClearDe();
        }
        // Clear Department
        private void ClearDe()
        {
            txtDeDepartmentName.Clear();
            department.DepartmentId = 0;
            btnSaveDe.Text = "Save";
            // To disable Delete button
            btnDeleteDe.Enabled = false;
        }
        // Fill dgvDepartments
        private void FilldgvDepartments()
        {
            dgvDepartments.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvDepartments.DataSource = db.Departments.ToList<Department>();
            }
        }
        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow.Index != -1)
            {
                department.DepartmentId = Convert.ToInt32(dgvDepartments
                    .CurrentRow.Cells[0].Value);
            }
            using (DBEntities db = new DBEntities())
            {
                department = db.Departments.Where(x => x.DepartmentId == department.DepartmentId)
                      .FirstOrDefault();
                txtDeDepartmentName.Text = department.DepartmentName;
            }
            btnSaveDe.Text = "Update";
            btnDeleteDe.Enabled = true;
        }
        // TapPage Position
        // CRUD Positions
        // Save Position
        private void btnSavePo_Click(object sender, EventArgs e)
        {
            if (txtPoPositionName.Text == "" || txtPoDailySalary.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                position.PositionName = txtPoPositionName.Text.Trim();
                position.DepartmentId = Convert.ToInt32(cmbPoDepartment.SelectedValue);
                position.DailySalary = Convert.ToDouble(txtPoDailySalary.Text.Trim());
                using (DBEntities db = new DBEntities())
                {
                    // Create
                    if (position.PositionId == 0)
                    {
                        db.Positions.Add(position);
                    }
                    // Update
                    else
                    {
                        db.Positions.AddOrUpdate(position);
                        // The above line is equivalent to the following line
                        // db.Entry(model).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearPo();
                FillAllComboBoxes();
                FillAllDataGridViews();
                ShowPopUpNoti("Successfully saved");
            }
            
        }
        // Delete Position
        private void btnDeletePo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
               "EF CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(position);
                    if (db.Entry(position).State == EntityState.Detached)
                    {
                        db.Positions.Attach(position);
                    }
                    db.Positions.Remove(position);
                    db.SaveChanges();
                    ClearPo();
                    FillAllComboBoxes();
                    FillAllDataGridViews();
                    ShowPopUpNoti("Successfully deleted");
                }
            }
        }
        // Reset Position
        private void btnResetPo_Click(object sender, EventArgs e)
        {
            ClearPo();
        }

        // Clear Position
        private void ClearPo()
        {
            txtPoPositionName.Clear();
            txtPoDailySalary.Clear();
            position.PositionId = 0;
            btnSavePo.Text = "Save";
            // To disable Delete button
            btnDeletePo.Enabled = false;
        }
        // Fill dgvPositions
        private void FilldgvPositions()
        {
            dgvDepartments.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvPositions.DataSource
                   = (from posi in db.Positions
                      join depa in db.Departments
                      on posi.DepartmentId equals depa.DepartmentId

                      select new
                      {
                          posi.PositionId,
                          posi.PositionName,
                          //posi.DepartmentId,
                          depa.DepartmentName,
                          posi.DailySalary
                      }).ToList();
            }
        }

        // Fill combobox cmbPoDepartment
        private void FillcmbPoDepartment()
        {
            // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
            cmbPoDepartment.ValueMember = "DepartmentId";
            cmbPoDepartment.DisplayMember = "DepartmentName";

            using (DBEntities db = new DBEntities())
            {
                cmbPoDepartment.DataSource = db.Departments.ToList<Department>();
            }
        }
        private void dgvPositions_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPositions.CurrentRow.Index != -1)
            {
                position.PositionId = Convert.ToInt32(dgvPositions
                    .CurrentRow.Cells[0].Value);
            }
            using (DBEntities db = new DBEntities())
            {
                position = db.Positions.Where(x => x.PositionId == position.PositionId)
                      .FirstOrDefault();
                txtPoPositionName.Text = position.PositionName;
                cmbPoDepartment.SelectedValue = position.DepartmentId;
                txtPoDailySalary.Text = position.DailySalary.ToString();
            }
            btnSavePo.Text = "Update";
            btnDeletePo.Enabled = true;
        }

        
    }
}