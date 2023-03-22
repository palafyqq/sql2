namespace KingIT_KravchenkoVasileva_ISiP321.Manager_C
{
    partial class SearchTC
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
            gbSearchTC = new GroupBox();
            txtNameTC = new MaterialSkin.Controls.MaterialTextBox();
            lblEnterNameTC = new MaterialSkin.Controls.MaterialLabel();
            btnClose = new MaterialSkin.Controls.MaterialButton();
            btnSearchTC = new MaterialSkin.Controls.MaterialButton();
            gbSearchTC.SuspendLayout();
            SuspendLayout();
            // 
            // gbSearchTC
            // 
            gbSearchTC.Controls.Add(txtNameTC);
            gbSearchTC.Controls.Add(lblEnterNameTC);
            gbSearchTC.Controls.Add(btnClose);
            gbSearchTC.Controls.Add(btnSearchTC);
            gbSearchTC.Location = new Point(19, 93);
            gbSearchTC.Name = "gbSearchTC";
            gbSearchTC.Size = new Size(484, 322);
            gbSearchTC.TabIndex = 0;
            gbSearchTC.TabStop = false;
            // 
            // txtNameTC
            // 
            txtNameTC.AnimateReadOnly = false;
            txtNameTC.BorderStyle = BorderStyle.None;
            txtNameTC.Depth = 0;
            txtNameTC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNameTC.LeadingIcon = null;
            txtNameTC.Location = new Point(18, 75);
            txtNameTC.MaxLength = 50;
            txtNameTC.MouseState = MaterialSkin.MouseState.OUT;
            txtNameTC.Multiline = false;
            txtNameTC.Name = "txtNameTC";
            txtNameTC.Size = new Size(438, 50);
            txtNameTC.TabIndex = 3;
            txtNameTC.Text = "";
            txtNameTC.TrailingIcon = null;
            txtNameTC.TextChanged += txtNameTC_TextChanged;
            // 
            // lblEnterNameTC
            // 
            lblEnterNameTC.AutoSize = true;
            lblEnterNameTC.Depth = 0;
            lblEnterNameTC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEnterNameTC.Location = new Point(18, 42);
            lblEnterNameTC.MouseState = MaterialSkin.MouseState.HOVER;
            lblEnterNameTC.Name = "lblEnterNameTC";
            lblEnterNameTC.Size = new Size(167, 19);
            lblEnterNameTC.TabIndex = 2;
            lblEnterNameTC.Text = "Введите название ТЦ:";
            // 
            // btnClose
            // 
            btnClose.AutoSize = false;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClose.Depth = 0;
            btnClose.HighEmphasis = true;
            btnClose.Icon = null;
            btnClose.Location = new Point(18, 248);
            btnClose.Margin = new Padding(4, 6, 4, 6);
            btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            btnClose.Name = "btnClose";
            btnClose.NoAccentTextColor = Color.Empty;
            btnClose.Size = new Size(438, 54);
            btnClose.TabIndex = 1;
            btnClose.Text = "Выйти";
            btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClose.UseAccentColor = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearchTC
            // 
            btnSearchTC.AutoSize = false;
            btnSearchTC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchTC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearchTC.Depth = 0;
            btnSearchTC.HighEmphasis = true;
            btnSearchTC.Icon = null;
            btnSearchTC.Location = new Point(18, 180);
            btnSearchTC.Margin = new Padding(4, 6, 4, 6);
            btnSearchTC.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearchTC.Name = "btnSearchTC";
            btnSearchTC.NoAccentTextColor = Color.Empty;
            btnSearchTC.Size = new Size(438, 56);
            btnSearchTC.TabIndex = 0;
            btnSearchTC.Text = "Найти";
            btnSearchTC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearchTC.UseAccentColor = false;
            btnSearchTC.UseVisualStyleBackColor = true;
            btnSearchTC.Click += btnSearchTC_Click;
            // 
            // SearchTC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 434);
            Controls.Add(gbSearchTC);
            MaximizeBox = false;
            Name = "SearchTC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск ТЦ";
            Load += SearchTC_Load;
            gbSearchTC.ResumeLayout(false);
            gbSearchTC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSearchTC;
        private MaterialSkin.Controls.MaterialTextBox txtNameTC;
        private MaterialSkin.Controls.MaterialLabel lblEnterNameTC;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton btnSearchTC;
    }
}