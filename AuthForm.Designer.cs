namespace ksyusha
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAuthorization = new System.Windows.Forms.GroupBox();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnEnter = new MaterialSkin.Controls.MaterialButton();
            this.txtCaptcha = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEnterCaptcha = new MaterialSkin.Controls.MaterialLabel();
            this.tbLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCaptcha = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblLogin = new MaterialSkin.Controls.MaterialLabel();
            this.gbAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthorization
            // 
            this.gbAuthorization.BackColor = System.Drawing.Color.LightGray;
            this.gbAuthorization.Controls.Add(this.btnExit);
            this.gbAuthorization.Controls.Add(this.btnEnter);
            this.gbAuthorization.Controls.Add(this.txtCaptcha);
            this.gbAuthorization.Controls.Add(this.tbPassword);
            this.gbAuthorization.Controls.Add(this.lblEnterCaptcha);
            this.gbAuthorization.Controls.Add(this.tbLogin);
            this.gbAuthorization.Controls.Add(this.lblCaptcha);
            this.gbAuthorization.Controls.Add(this.lblPassword);
            this.gbAuthorization.Controls.Add(this.lblLogin);
            this.gbAuthorization.Location = new System.Drawing.Point(12, 12);
            this.gbAuthorization.Name = "gbAuthorization";
            this.gbAuthorization.Size = new System.Drawing.Size(314, 331);
            this.gbAuthorization.TabIndex = 0;
            this.gbAuthorization.TabStop = false;
            this.gbAuthorization.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(13, 267);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(283, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выйти";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = false;
            this.btnEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEnter.Depth = 0;
            this.btnEnter.HighEmphasis = true;
            this.btnEnter.Icon = null;
            this.btnEnter.Location = new System.Drawing.Point(13, 219);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnter.Size = new System.Drawing.Size(283, 36);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Войти";
            this.btnEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnter.UseAccentColor = false;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.AnimateReadOnly = false;
            this.txtCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCaptcha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCaptcha.Depth = 0;
            this.txtCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaptcha.HideSelection = true;
            this.txtCaptcha.LeadingIcon = null;
            this.txtCaptcha.Location = new System.Drawing.Point(12, 95);
            this.txtCaptcha.MaxLength = 32767;
            this.txtCaptcha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.PasswordChar = '\0';
            this.txtCaptcha.PrefixSuffixText = null;
            this.txtCaptcha.ReadOnly = false;
            this.txtCaptcha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCaptcha.SelectedText = "";
            this.txtCaptcha.SelectionLength = 0;
            this.txtCaptcha.SelectionStart = 0;
            this.txtCaptcha.ShortcutsEnabled = true;
            this.txtCaptcha.Size = new System.Drawing.Size(278, 48);
            this.txtCaptcha.TabIndex = 6;
            this.txtCaptcha.TabStop = false;
            this.txtCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCaptcha.TrailingIcon = null;
            this.txtCaptcha.UseSystemPasswordChar = false;
            this.txtCaptcha.Visible = false;
            this.txtCaptcha.Click += new System.EventHandler(this.txtCaptcha_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(13, 114);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Password = true;
            this.tbPassword.Size = new System.Drawing.Size(277, 50);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "";
            this.tbPassword.TrailingIcon = null;
            // 
            // lblEnterCaptcha
            // 
            this.lblEnterCaptcha.AutoSize = true;
            this.lblEnterCaptcha.Depth = 0;
            this.lblEnterCaptcha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnterCaptcha.Location = new System.Drawing.Point(13, 54);
            this.lblEnterCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnterCaptcha.Name = "lblEnterCaptcha";
            this.lblEnterCaptcha.Size = new System.Drawing.Size(115, 19);
            this.lblEnterCaptcha.TabIndex = 2;
            this.lblEnterCaptcha.Text = "Введите капчу:";
            this.lblEnterCaptcha.Visible = false;
            this.lblEnterCaptcha.Click += new System.EventHandler(this.lblEnterCaptcha_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.AnimateReadOnly = false;
            this.tbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLogin.Depth = 0;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLogin.HideSelection = true;
            this.tbLogin.LeadingIcon = null;
            this.tbLogin.Location = new System.Drawing.Point(13, 41);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.PrefixSuffixText = null;
            this.tbLogin.ReadOnly = false;
            this.tbLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(277, 48);
            this.tbLogin.TabIndex = 4;
            this.tbLogin.TabStop = false;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLogin.TrailingIcon = null;
            this.tbLogin.UseSystemPasswordChar = false;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.BackColor = System.Drawing.SystemColors.Control;
            this.lblCaptcha.Depth = 0;
            this.lblCaptcha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCaptcha.Location = new System.Drawing.Point(126, 167);
            this.lblCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(1, 0);
            this.lblCaptcha.TabIndex = 3;
            this.lblCaptcha.Visible = false;
            this.lblCaptcha.Click += new System.EventHandler(this.lblCaptcha_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(12, 92);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Введите пароль:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Depth = 0;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogin.Location = new System.Drawing.Point(13, 19);
            this.lblLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(114, 19);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Введите логин:";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(340, 354);
            this.Controls.Add(this.gbAuthorization);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAuthorization.ResumeLayout(false);
            this.gbAuthorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbAuthorization;
        private MaterialSkin.Controls.MaterialLabel lblEnterCaptcha;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblLogin;
        private MaterialSkin.Controls.MaterialTextBox2 tbLogin;
        private MaterialSkin.Controls.MaterialLabel lblCaptcha;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnEnter;
        private MaterialSkin.Controls.MaterialTextBox2 txtCaptcha;
    }
}