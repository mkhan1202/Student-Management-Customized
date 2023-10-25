namespace Student_Management_Core
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSidebar = new Guna.UI.WinForms.GunaPanel();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnStudentProfile = new Guna.UI.WinForms.GunaButton();
            this.btnViewStudent = new Guna.UI.WinForms.GunaButton();
            this.btnEditStudent = new Guna.UI.WinForms.GunaButton();
            this.btnAddStudent = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.pnlSidebar.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.pnlSidebar.Controls.Add(this.btnSearch);
            this.pnlSidebar.Controls.Add(this.btnStudentProfile);
            this.pnlSidebar.Controls.Add(this.btnViewStudent);
            this.pnlSidebar.Controls.Add(this.btnEditStudent);
            this.pnlSidebar.Controls.Add(this.btnAddStudent);
            this.pnlSidebar.Controls.Add(this.gunaPanel1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(400, 953);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffsetX = 35;
            this.btnSearch.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch.Location = new System.Drawing.Point(0, 494);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnSearch.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.OnHoverImage")));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(400, 70);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.TextOffsetX = 20;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStudentProfile
            // 
            this.btnStudentProfile.AnimationHoverSpeed = 0.07F;
            this.btnStudentProfile.AnimationSpeed = 0.03F;
            this.btnStudentProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentProfile.BaseColor = System.Drawing.Color.Transparent;
            this.btnStudentProfile.BorderColor = System.Drawing.Color.Black;
            this.btnStudentProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudentProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudentProfile.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnStudentProfile.ForeColor = System.Drawing.Color.White;
            this.btnStudentProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentProfile.Image")));
            this.btnStudentProfile.ImageOffsetX = 35;
            this.btnStudentProfile.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStudentProfile.Location = new System.Drawing.Point(0, 425);
            this.btnStudentProfile.Name = "btnStudentProfile";
            this.btnStudentProfile.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnStudentProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudentProfile.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnStudentProfile.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnStudentProfile.OnHoverImage")));
            this.btnStudentProfile.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudentProfile.Size = new System.Drawing.Size(400, 70);
            this.btnStudentProfile.TabIndex = 1;
            this.btnStudentProfile.Text = "Student Profile";
            this.btnStudentProfile.TextOffsetX = 20;
            this.btnStudentProfile.Click += new System.EventHandler(this.btnStudentProfile_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.AnimationHoverSpeed = 0.07F;
            this.btnViewStudent.AnimationSpeed = 0.03F;
            this.btnViewStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnViewStudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnViewStudent.BorderColor = System.Drawing.Color.Black;
            this.btnViewStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewStudent.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnViewStudent.ForeColor = System.Drawing.Color.White;
            this.btnViewStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStudent.Image")));
            this.btnViewStudent.ImageOffsetX = 35;
            this.btnViewStudent.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewStudent.Location = new System.Drawing.Point(0, 354);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnViewStudent.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnViewStudent.OnHoverImage")));
            this.btnViewStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewStudent.Size = new System.Drawing.Size(400, 70);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Student Info";
            this.btnViewStudent.TextOffsetX = 20;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.AnimationHoverSpeed = 0.07F;
            this.btnEditStudent.AnimationSpeed = 0.03F;
            this.btnEditStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditStudent.BorderColor = System.Drawing.Color.Black;
            this.btnEditStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditStudent.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnEditStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStudent.Image")));
            this.btnEditStudent.ImageOffsetX = 35;
            this.btnEditStudent.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEditStudent.Location = new System.Drawing.Point(0, 284);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnEditStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnEditStudent.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnEditStudent.OnHoverImage")));
            this.btnEditStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditStudent.Size = new System.Drawing.Size(400, 70);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Edit Student Info";
            this.btnEditStudent.TextOffsetX = 20;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AnimationHoverSpeed = 0.07F;
            this.btnAddStudent.AnimationSpeed = 0.03F;
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageOffsetX = 35;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddStudent.Location = new System.Drawing.Point(0, 214);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnAddStudent.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.OnHoverImage")));
            this.btnAddStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStudent.Size = new System.Drawing.Size(400, 70);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student Info";
            this.btnAddStudent.TextOffsetX = 20;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(400, 63);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(51, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(292, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "CORE STUDY POINT";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(400, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1502, 953);
            this.pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.Text = "Core";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlSidebar;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnAddStudent;
        private Guna.UI.WinForms.GunaButton btnEditStudent;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnStudentProfile;
        private Guna.UI.WinForms.GunaButton btnViewStudent;

    }
}

