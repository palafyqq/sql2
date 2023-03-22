namespace KingIT_KravchenkoVasileva_ISiP321.Manager_C
{
    partial class FilterTC
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
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.cmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.lblCity = new MaterialSkin.Controls.MaterialLabel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbMake = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbBuild = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbPlan = new MaterialSkin.Controls.MaterialCheckbox();
            this.bntApply = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.gbSort.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.cmbCity);
            this.gbSort.Controls.Add(this.lblCity);
            this.gbSort.Location = new System.Drawing.Point(38, 64);
            this.gbSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSort.Name = "gbSort";
            this.gbSort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSort.Size = new System.Drawing.Size(303, 115);
            this.gbSort.TabIndex = 0;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Сортировка";
            // 
            // cmbCity
            // 
            this.cmbCity.AutoResize = false;
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCity.Depth = 0;
            this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCity.DropDownHeight = 174;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.DropDownWidth = 121;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.ItemHeight = 43;
            this.cmbCity.Location = new System.Drawing.Point(16, 56);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCity.MaxDropDownItems = 4;
            this.cmbCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(268, 49);
            this.cmbCity.StartIndex = 0;
            this.cmbCity.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Depth = 0;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCity.Location = new System.Drawing.Point(16, 31);
            this.lblCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(115, 19);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Введите город:";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbMake);
            this.gbFilter.Controls.Add(this.cbBuild);
            this.gbFilter.Controls.Add(this.cbPlan);
            this.gbFilter.Location = new System.Drawing.Point(38, 196);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Size = new System.Drawing.Size(303, 146);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            // 
            // cbMake
            // 
            this.cbMake.AutoSize = true;
            this.cbMake.Depth = 0;
            this.cbMake.Location = new System.Drawing.Point(16, 100);
            this.cbMake.Margin = new System.Windows.Forms.Padding(0);
            this.cbMake.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbMake.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbMake.Name = "cbMake";
            this.cbMake.ReadOnly = false;
            this.cbMake.Ripple = true;
            this.cbMake.Size = new System.Drawing.Size(124, 37);
            this.cbMake.TabIndex = 2;
            this.cbMake.Text = "Реализация";
            this.cbMake.UseVisualStyleBackColor = true;
            this.cbMake.CheckedChanged += new System.EventHandler(this.cbMake_CheckedChanged);
            // 
            // cbBuild
            // 
            this.cbBuild.AutoSize = true;
            this.cbBuild.Depth = 0;
            this.cbBuild.Location = new System.Drawing.Point(16, 62);
            this.cbBuild.Margin = new System.Windows.Forms.Padding(0);
            this.cbBuild.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbBuild.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbBuild.Name = "cbBuild";
            this.cbBuild.ReadOnly = false;
            this.cbBuild.Ripple = true;
            this.cbBuild.Size = new System.Drawing.Size(148, 37);
            this.cbBuild.TabIndex = 1;
            this.cbBuild.Text = "Строительство";
            this.cbBuild.UseVisualStyleBackColor = true;
            this.cbBuild.CheckedChanged += new System.EventHandler(this.cbBuild_CheckedChanged);
            // 
            // cbPlan
            // 
            this.cbPlan.AutoSize = true;
            this.cbPlan.Depth = 0;
            this.cbPlan.Location = new System.Drawing.Point(16, 26);
            this.cbPlan.Margin = new System.Windows.Forms.Padding(0);
            this.cbPlan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPlan.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.ReadOnly = false;
            this.cbPlan.Ripple = true;
            this.cbPlan.Size = new System.Drawing.Size(73, 37);
            this.cbPlan.TabIndex = 0;
            this.cbPlan.Text = "План";
            this.cbPlan.UseVisualStyleBackColor = true;
            this.cbPlan.CheckedChanged += new System.EventHandler(this.cbPlan_CheckedChanged);
            // 
            // bntApply
            // 
            this.bntApply.AutoSize = false;
            this.bntApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bntApply.Depth = 0;
            this.bntApply.HighEmphasis = true;
            this.bntApply.Icon = null;
            this.bntApply.Location = new System.Drawing.Point(38, 358);
            this.bntApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntApply.Name = "bntApply";
            this.bntApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bntApply.Size = new System.Drawing.Size(303, 34);
            this.bntApply.TabIndex = 2;
            this.bntApply.Text = "Применить";
            this.bntApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bntApply.UseAccentColor = false;
            this.bntApply.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(38, 400);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(303, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FilterTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bntApply);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbSort);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FilterTC";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка и фильтрация ЕЦ";
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSort;
        private MaterialSkin.Controls.MaterialComboBox cmbCity;
        private MaterialSkin.Controls.MaterialLabel lblCity;
        private GroupBox gbFilter;
        private MaterialSkin.Controls.MaterialCheckbox cbMake;
        private MaterialSkin.Controls.MaterialCheckbox cbBuild;
        private MaterialSkin.Controls.MaterialCheckbox cbPlan;
        private MaterialSkin.Controls.MaterialButton bntApply;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}