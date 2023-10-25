using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Management_Core
{
    public partial class Add_Student_Info : Form
    {
        public Add_Student_Info()
        {
            InitializeComponent();
        }

        private void Add_Student_Info_Load(object sender, EventArgs e)
        {
            FillGender();
            FillClass();
            FillSubject();
            pnlAddMessage.Visible = false;
        }

        private void FillSubject()
        {
            var mn = new Manage();
            var list = mn.GetAllSubject();

            cbxSubject.ValueMember = "Subject_Id";
            cbxSubject.DisplayMember = "Subject_Name";
            cbxSubject.DataSource = list;
        }

        private void FillClass()
        {
            var mn = new Manage();
            var list = mn.GetAllClass();

            cbxClass.ValueMember = "Class_Id";
            cbxClass.DisplayMember = "Class_Name";
            cbxClass.DataSource = list;
        }

        private void FillGender()
        {
            var mn = new Manage();
            var list = mn.GetAllGender();

            cbxGender.ValueMember = "Gender_Id";
            cbxGender.DisplayMember = "Gender_Type";
            cbxGender.DataSource = list;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                var pfd = new OpenFileDialog();
                pfd.Title = @"Pls Select a Photo...";
                pfd.Filter = @"JPG|*.jpg|PNG|*.png|JPEG|*jpeg";
                pfd.Multiselect = false;

                if (pfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.pbxImage.ImageLocation = pfd.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Internal error please contact to Developer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static byte[] ConvertFileToByte(string spath)
        {
            byte[] data = null;
            var finfo = new FileInfo(spath);
            var numByte = finfo.Length;
            var fstrem = new FileStream(spath, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fstrem);
            data = br.ReadBytes((int)numByte);
            return data;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Core_StudyEntities();
                var tb = new Student_Information();

                tb.Student_Id = Convert.ToInt32(txtStudentId.Text.Trim());
                tb.Name = txtName.Text.Trim();
                tb.Father_s_Name = txtFatherName.Text.Trim();
                tb.Mother_s_Name = txtMotherName.Text.Trim();
                tb.Address = txtAddress.Text.Trim();
                tb.Gender_Id = Convert.ToInt32(cbxGender.SelectedValue);
                tb.Personal_Contact = txtPersonalContact.Text.Trim();
                tb.Father_s_Contact = txtFatherContact.Text.Trim();
                tb.Mother_s_Contact = txtMotherContact.Text.Trim();
                tb.Birth_Date = Convert.ToDateTime(dteBirthDate.Value);
                tb.Class = Convert.ToInt32(cbxClass.SelectedValue);
                tb.Roll = Convert.ToInt32(txtRoll.Text.Trim());
                tb.Institution = txtInstitution.Text.Trim();
                tb.Section = txtSection.Text.Trim();
                tb.Subject_Id = Convert.ToInt32(cbxSubject.SelectedValue);
                tb.Admission_Date = Convert.ToDateTime(dteAdmissionDate.Value);
                tb.Image = ConvertFileToByte(pbxImage.ImageLocation);

                context.Student_Information.Add(tb);
                context.SaveChanges();
                pnlAddMessage.Visible = true;
                tmrAddMessage.Start();
                ClearField();

            }

            catch (Exception)
            {
                MessageBox.Show(@"Internal error please contact to Developer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tmrAddMessage_Tick(object sender, EventArgs e)
        {
            pnlAddMessage.Visible = false;
        }

        public void ClearField()
        {
            txtStudentId.Text = txtName.Text = txtFatherName.Text = txtMotherName.Text = txtAddress.Text = txtPersonalContact.Text = txtFatherContact.Text = txtMotherContact.Text = txtRoll.Text = txtInstitution.Text = txtSection.Text = null;
            cbxClass.Text = cbxGender.Text = cbxSubject.Text = string.Empty;
            dteBirthDate = dteAdmissionDate = null;
        }

        
    }
}
