namespace WinformsDUCCompany1a
{
    partial class Login_Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Register_Form));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtUserPasswordLo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserNameLo = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmUserPasswordRe = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserEmailRe = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.txtUserPasswordRe = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserNameRe = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login256.png");
            this.imageList1.Images.SetKeyName(1, "user256.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageLogin);
            this.materialTabControl1.Controls.Add(this.tabPageRegister);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(449, 448);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.materialLabel1);
            this.tabPageLogin.Controls.Add(this.pictureBox1);
            this.tabPageLogin.Controls.Add(this.label2);
            this.tabPageLogin.Controls.Add(this.label1);
            this.tabPageLogin.Controls.Add(this.btnLogin);
            this.tabPageLogin.Controls.Add(this.txtUserPasswordLo);
            this.tabPageLogin.Controls.Add(this.txtUserNameLo);
            this.tabPageLogin.ImageKey = "login256.png";
            this.tabPageLogin.Location = new System.Drawing.Point(4, 31);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(441, 413);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(156, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 41);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(23, 306);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserPasswordLo
            // 
            this.txtUserPasswordLo.AnimateReadOnly = false;
            this.txtUserPasswordLo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPasswordLo.Depth = 0;
            this.txtUserPasswordLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPasswordLo.LeadingIcon = null;
            this.txtUserPasswordLo.Location = new System.Drawing.Point(146, 191);
            this.txtUserPasswordLo.MaxLength = 50;
            this.txtUserPasswordLo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserPasswordLo.Multiline = false;
            this.txtUserPasswordLo.Name = "txtUserPasswordLo";
            this.txtUserPasswordLo.Password = true;
            this.txtUserPasswordLo.Size = new System.Drawing.Size(221, 50);
            this.txtUserPasswordLo.TabIndex = 4;
            this.txtUserPasswordLo.Text = "";
            this.txtUserPasswordLo.TrailingIcon = null;
            // 
            // txtUserNameLo
            // 
            this.txtUserNameLo.AnimateReadOnly = false;
            this.txtUserNameLo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameLo.Depth = 0;
            this.txtUserNameLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNameLo.LeadingIcon = null;
            this.txtUserNameLo.Location = new System.Drawing.Point(146, 135);
            this.txtUserNameLo.MaxLength = 50;
            this.txtUserNameLo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserNameLo.Multiline = false;
            this.txtUserNameLo.Name = "txtUserNameLo";
            this.txtUserNameLo.Size = new System.Drawing.Size(221, 50);
            this.txtUserNameLo.TabIndex = 1;
            this.txtUserNameLo.Text = "";
            this.txtUserNameLo.TrailingIcon = null;
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.materialLabel2);
            this.tabPageRegister.Controls.Add(this.label6);
            this.tabPageRegister.Controls.Add(this.txtConfirmUserPasswordRe);
            this.tabPageRegister.Controls.Add(this.label5);
            this.tabPageRegister.Controls.Add(this.txtUserEmailRe);
            this.tabPageRegister.Controls.Add(this.label3);
            this.tabPageRegister.Controls.Add(this.label4);
            this.tabPageRegister.Controls.Add(this.btnRegister);
            this.tabPageRegister.Controls.Add(this.txtUserPasswordRe);
            this.tabPageRegister.Controls.Add(this.txtUserNameRe);
            this.tabPageRegister.Controls.Add(this.pictureBox2);
            this.tabPageRegister.ImageKey = "user256.png";
            this.tabPageRegister.Location = new System.Drawing.Point(4, 31);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(441, 413);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Register";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(140, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 41);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Register";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Confirm Password";
            // 
            // txtConfirmUserPasswordRe
            // 
            this.txtConfirmUserPasswordRe.AnimateReadOnly = false;
            this.txtConfirmUserPasswordRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmUserPasswordRe.Depth = 0;
            this.txtConfirmUserPasswordRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmUserPasswordRe.LeadingIcon = null;
            this.txtConfirmUserPasswordRe.Location = new System.Drawing.Point(147, 280);
            this.txtConfirmUserPasswordRe.MaxLength = 50;
            this.txtConfirmUserPasswordRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmUserPasswordRe.Multiline = false;
            this.txtConfirmUserPasswordRe.Name = "txtConfirmUserPasswordRe";
            this.txtConfirmUserPasswordRe.Password = true;
            this.txtConfirmUserPasswordRe.Size = new System.Drawing.Size(221, 50);
            this.txtConfirmUserPasswordRe.TabIndex = 18;
            this.txtConfirmUserPasswordRe.Text = "";
            this.txtConfirmUserPasswordRe.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // txtUserEmailRe
            // 
            this.txtUserEmailRe.AnimateReadOnly = false;
            this.txtUserEmailRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmailRe.Depth = 0;
            this.txtUserEmailRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserEmailRe.LeadingIcon = null;
            this.txtUserEmailRe.Location = new System.Drawing.Point(147, 169);
            this.txtUserEmailRe.MaxLength = 50;
            this.txtUserEmailRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserEmailRe.Multiline = false;
            this.txtUserEmailRe.Name = "txtUserEmailRe";
            this.txtUserEmailRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserEmailRe.TabIndex = 16;
            this.txtUserEmailRe.Text = "";
            this.txtUserEmailRe.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(18, 354);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(89, 36);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUserPasswordRe
            // 
            this.txtUserPasswordRe.AnimateReadOnly = false;
            this.txtUserPasswordRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPasswordRe.Depth = 0;
            this.txtUserPasswordRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPasswordRe.LeadingIcon = null;
            this.txtUserPasswordRe.Location = new System.Drawing.Point(147, 224);
            this.txtUserPasswordRe.MaxLength = 50;
            this.txtUserPasswordRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserPasswordRe.Multiline = false;
            this.txtUserPasswordRe.Name = "txtUserPasswordRe";
            this.txtUserPasswordRe.Password = true;
            this.txtUserPasswordRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserPasswordRe.TabIndex = 11;
            this.txtUserPasswordRe.Text = "";
            this.txtUserPasswordRe.TrailingIcon = null;
            // 
            // txtUserNameRe
            // 
            this.txtUserNameRe.AnimateReadOnly = false;
            this.txtUserNameRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameRe.Depth = 0;
            this.txtUserNameRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNameRe.LeadingIcon = null;
            this.txtUserNameRe.Location = new System.Drawing.Point(146, 113);
            this.txtUserNameRe.MaxLength = 50;
            this.txtUserNameRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserNameRe.Multiline = false;
            this.txtUserNameRe.Name = "txtUserNameRe";
            this.txtUserNameRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserNameRe.TabIndex = 10;
            this.txtUserNameRe.Text = "";
            this.txtUserNameRe.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformsDUCCompany1a.Properties.Resources.login256;
            this.pictureBox1.Location = new System.Drawing.Point(163, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformsDUCCompany1a.Properties.Resources.user256;
            this.pictureBox2.Location = new System.Drawing.Point(164, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Login_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 515);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Login_Register_Form";
            this.Text = "DUC COMPANY         ";
            this.Load += new System.EventHandler(this.Login_Register_Form_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.tabPageRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private MaterialSkin.Controls.MaterialTextBox txtUserNameLo;
        private MaterialSkin.Controls.MaterialTextBox txtUserPasswordLo;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialTextBox txtUserPasswordRe;
        private MaterialSkin.Controls.MaterialTextBox txtUserNameRe;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmUserPasswordRe;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtUserEmailRe;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

