using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Core
{
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            FillClass();
            FillGender();
            FillSubject();
        }

        private void FillSubject()
        {
            var mn = new Manage();
            var data = mn.GetAllSubject();

            cbxSubject.DisplayMember = "Subject_Name";
            cbxSubject.ValueMember = "Subject_Id";
            cbxSubject.DataSource = data;
            cbxSubject.Text = "Select Subject";
        }

        private void FillGender()
        {
            var mn = new Manage();
            var data = mn.GetAllGender();

            cbxGender.DisplayMember = "Gender_Type";
            cbxGender.ValueMember = "Gender_Id";
            cbxGender.DataSource = data;
            cbxGender.Text = "Select Gender";
        }

        private void FillClass()
        {
            var mn = new Manage();
            var list = mn.GetAllClass();

            cbxClass.DisplayMember = "Class_Name";
            cbxClass.ValueMember = "Class_Id";
            cbxClass.DataSource = list;

            
        }

        private void btnSearchView_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cbxGender.SelectedValue);
            int b = Convert.ToInt32(cbxClass.SelectedValue);
            int c = Convert.ToInt32(cbxSubject.SelectedValue);

            var list = new Manage().GetDataBySearch(a, b, c);

            dgvSearchStudentData.DataSource = list;
        }
    }
}
