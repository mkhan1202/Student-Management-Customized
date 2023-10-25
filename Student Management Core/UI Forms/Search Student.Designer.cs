namespace Student_Management_Core
{
    partial class Search_Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnResetValue = new Guna.UI.WinForms.GunaButton();
            this.btnSearchView = new Guna.UI.WinForms.GunaButton();
            this.cbxGender = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dgvSearchStudentData = new Guna.UI.WinForms.GunaDataGridView();
            this.Class = new Guna.UI.WinForms.GunaLabel();
            this.cbxClass = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbxSubject = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetValue
            // 
            this.btnResetValue.AnimationHoverSpeed = 0.07F;
            this.btnResetValue.AnimationSpeed = 0.03F;
            this.btnResetValue.BackColor = System.Drawing.Color.Transparent;
            this.btnResetValue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnResetValue.BorderColor = System.Drawing.Color.Black;
            this.btnResetValue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnResetValue.FocusedColor = System.Drawing.Color.Empty;
            this.btnResetValue.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.btnResetValue.ForeColor = System.Drawing.Color.White;
            this.btnResetValue.Image = null;
            this.btnResetValue.ImageSize = new System.Drawing.Size(20, 20);
            this.btnResetValue.Location = new System.Drawing.Point(1390, 97);
            this.btnResetValue.Name = "btnResetValue";
            this.btnResetValue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnResetValue.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnResetValue.OnHoverForeColor = System.Drawing.Color.White;
            this.btnResetValue.OnHoverImage = null;
            this.btnResetValue.OnPressedColor = System.Drawing.Color.Black;
            this.btnResetValue.Radius = 2;
            this.btnResetValue.Size = new System.Drawing.Size(150, 35);
            this.btnResetValue.TabIndex = 54;
            this.btnResetValue.Text = "Reset";
            this.btnResetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchView
            // 
            this.btnSearchView.AnimationHoverSpeed = 0.07F;
            this.btnSearchView.AnimationSpeed = 0.03F;
            this.btnSearchView.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchView.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnSearchView.BorderColor = System.Drawing.Color.Black;
            this.btnSearchView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchView.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearchView.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearchView.ForeColor = System.Drawing.Color.White;
            this.btnSearchView.Image = null;
            this.btnSearchView.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearchView.Location = new System.Drawing.Point(1211, 97);
            this.btnSearchView.Name = "btnSearchView";
            this.btnSearchView.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnSearchView.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSearchView.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchView.OnHoverImage = null;
            this.btnSearchView.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearchView.Radius = 2;
            this.btnSearchView.Size = new System.Drawing.Size(150, 35);
            this.btnSearchView.TabIndex = 55;
            this.btnSearchView.Text = "Search";
            this.btnSearchView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchView.Click += new System.EventHandler(this.btnSearchView_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.BackColor = System.Drawing.Color.Transparent;
            this.cbxGender.BaseColor = System.Drawing.Color.White;
            this.cbxGender.BorderColor = System.Drawing.Color.Silver;
            this.cbxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FocusedColor = System.Drawing.Color.Empty;
            this.cbxGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGender.ForeColor = System.Drawing.Color.Black;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(580, 101);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxGender.Size = new System.Drawing.Size(165, 31);
            this.cbxGender.TabIndex = 53;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.gunaLabel12.Location = new System.Drawing.Point(574, 75);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(75, 23);
            this.gunaLabel12.TabIndex = 52;
            this.gunaLabel12.Text = "Gender:";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.ForeColor = System.Drawing.Color.White;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1564, 55);
            this.gunaPanel1.TabIndex = 47;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto", 16F);
            this.gunaLabel1.Location = new System.Drawing.Point(11, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(198, 33);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Search Student";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Roboto", 13F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.gunaLabel4.Location = new System.Drawing.Point(29, 172);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(136, 27);
            this.gunaLabel4.TabIndex = 49;
            this.gunaLabel4.Text = "Student Info:";
            // 
            // dgvSearchStudentData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchStudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchStudentData.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearchStudentData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearchStudentData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchStudentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchStudentData.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchStudentData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchStudentData.EnableHeadersVisualStyles = false;
            this.dgvSearchStudentData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchStudentData.Location = new System.Drawing.Point(36, 218);
            this.dgvSearchStudentData.Name = "dgvSearchStudentData";
            this.dgvSearchStudentData.RowHeadersVisible = false;
            this.dgvSearchStudentData.RowTemplate.Height = 24;
            this.dgvSearchStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchStudentData.Size = new System.Drawing.Size(1504, 708);
            this.dgvSearchStudentData.TabIndex = 56;
            this.dgvSearchStudentData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvSearchStudentData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSearchStudentData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSearchStudentData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSearchStudentData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSearchStudentData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSearchStudentData.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSearchStudentData.ThemeStyle.ReadOnly = false;
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchStudentData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Roboto", 11F);
            this.Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.Class.Location = new System.Drawing.Point(779, 75);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(62, 23);
            this.Class.TabIndex = 52;
            this.Class.Text = "Class:";
            // 
            // cbxClass
            // 
            this.cbxClass.BackColor = System.Drawing.Color.Transparent;
            this.cbxClass.BaseColor = System.Drawing.Color.White;
            this.cbxClass.BorderColor = System.Drawing.Color.Silver;
            this.cbxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.FocusedColor = System.Drawing.Color.Empty;
            this.cbxClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxClass.ForeColor = System.Drawing.Color.Black;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(785, 101);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxClass.Size = new System.Drawing.Size(165, 31);
            this.cbxClass.TabIndex = 53;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.gunaLabel5.Location = new System.Drawing.Point(986, 75);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(78, 23);
            this.gunaLabel5.TabIndex = 52;
            this.gunaLabel5.Text = "Subject:";
            // 
            // cbxSubject
            // 
            this.cbxSubject.BackColor = System.Drawing.Color.Transparent;
            this.cbxSubject.BaseColor = System.Drawing.Color.White;
            this.cbxSubject.BorderColor = System.Drawing.Color.Silver;
            this.cbxSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSubject.ForeColor = System.Drawing.Color.Black;
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(992, 101);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSubject.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSubject.Size = new System.Drawing.Size(165, 31);
            this.cbxSubject.TabIndex = 53;
            // 
            // Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1564, 953);
            this.Controls.Add(this.dgvSearchStudentData);
            this.Controls.Add(this.btnResetValue);
            this.Controls.Add(this.btnSearchView);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Search_Student";
            this.Text = "Search_Student";
            this.Load += new System.EventHandler(this.Search_Student_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnResetValue;
        private Guna.UI.WinForms.GunaButton btnSearchView;
        private Guna.UI.WinForms.GunaComboBox cbxGender;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dgvSearchStudentData;
        private Guna.UI.WinForms.GunaLabel Class;
        private Guna.UI.WinForms.GunaComboBox cbxClass;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cbxSubject;
    }
}