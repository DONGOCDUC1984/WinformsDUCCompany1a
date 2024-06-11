using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsDUCCompany1a.Forms;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WinformsDUCCompany1a
{
    public partial class Login_Register_Form : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public Login_Register_Form()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.DeepOrange400, Primary.DeepOrange600, Primary.Indigo100,
                Accent.DeepOrange700 , TextShade.WHITE);
        }
      
        User model = new User();
        private void Login_Register_Form_Load(object sender, EventArgs e)
        {
           Clear();
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
        private void Clear()
        {
            // For Login
            txtUserNameLo.Clear();
            txtUserPasswordLo.Clear();
            // For Register
            txtUserNameRe.Clear();
            txtUserEmailRe.Clear();
            txtUserPasswordRe.Clear();
            txtConfirmUserPasswordRe.Clear();
        }
        // Get Hashed Password
        private string GetHashedPassword(string input)
        {
            MD5 md5 = MD5.Create();
            // Convert the input string to a byte array and compute the hash
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new stringbuilder to collect the bytes and create a string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var user = db.Users.ToList<User>()
                    .Where(x => x.UserName == txtUserNameLo.Text.Trim()
                     && x.UserPassword == GetHashedPassword(txtUserPasswordLo.Text.Trim()))
                    .FirstOrDefault();
                if (user != null)
                {
                    // The following lines are used to send data from this form to MainForm
                    MainForm mainForm = new MainForm();
                    mainForm.UserName = user.UserName;
                    mainForm.UserRole = user.UserRole;
                    mainForm.UserEmail = user.UserEmail;
                    this.Hide();
                    mainForm.Show();
                    ShowPopUpNoti("Successfully logged in");
                }
                else
                {
                    MessageBox.Show("Wrong username or wrong password",
                            "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserNameRe.Text == "" || txtUserEmailRe.Text == "" ||
               txtUserPasswordRe.Text == "" || txtConfirmUserPasswordRe.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtUserPasswordRe.Text != txtConfirmUserPasswordRe.Text)
                {
                    MessageBox.Show("Passwords do not match",
                   "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // For Admin
                    // string Role = "Admin";

                    // For User
                    string UserRole = "User";
                    model.UserName = txtUserNameRe.Text.Trim();
                    model.UserEmail = txtUserEmailRe.Text.Trim();
                    model.UserPassword = GetHashedPassword(txtUserPasswordRe.Text.Trim());
                    model.UserRole = UserRole;
                    using (DBEntities db = new DBEntities())
                    {
                        db.Users.Add(model);
                        db.SaveChanges();
                    }
                   
                    // The following lines are used to send data from this form to MainForm
                    MainForm mainForm = new MainForm();
                    mainForm.UserName = txtUserNameRe.Text.Trim();
                    mainForm.UserRole = UserRole;
                    mainForm.UserEmail = txtUserEmailRe.Text.Trim();
                    this.Hide();
                    mainForm.Show();
                    ShowPopUpNoti("Successfully registered");
                    Clear();

                }
            }
        }
    }
}
