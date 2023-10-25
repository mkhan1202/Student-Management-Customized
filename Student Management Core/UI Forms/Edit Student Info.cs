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
    public partial class Edit_Student_Info : Form
    {
        public Edit_Student_Info()
        {
            InitializeComponent();
        }

        private void Edit_Student_Info_Load(object sender, EventArgs e)
        {
            FillClass();
            FillGender();
            FillSubject();
            btnMessage.Visible = false;
            
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
                MessageBox.Show(@"Technical Problem please contact Admin");
            }
        }

        
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var context = new Core_StudyEntities();
            var tb = context.Student_Information.ToList().Where(x => x.Student_Id == Convert.ToInt32(txtSearchId.Text.ToString())).FirstOrDefault();

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

            //context.Student_Information.Add(tb);
            context.SaveChanges();
            
            UpdateMsg();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMsg();
        }

        private static Image ConvertByteToImage(byte[] photo)
        {
            Image newImage;
            using (var ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
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

        public void DeleteMsg()
        {
            btnMessage.Text = "Student deleted Successfuly!";
            btnMessage.BaseColor = Color.FromArgb(255, 255, 100, 100);
            btnMessage.OnHoverBaseColor = Color.FromArgb(255, 255, 100, 100);
            btnMessage.Visible = true;
            tmrEditStudent.Start();
        }


        public void UpdateMsg()
        {
            btnMessage.Text = "Student update Successfuly!";
            btnMessage.BaseColor = Color.FromArgb(255, 70, 200, 70);
            btnMessage.OnHoverBaseColor = Color.FromArgb(255, 70, 200, 70);
            btnMessage.Visible = true;
            tmrEditStudent.Start();
        }

        private void tmrEditStudent_Tick(object sender, EventArgs e)
        {
            btnMessage.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var db = new Core_StudyEntities();
            var obj = db.Student_Information.ToList().Where(x => x.Student_Id == Convert.ToInt32(txtSearchId.Text.ToString())).FirstOrDefault();

            txtStudentId.Text = obj.Student_Id.ToString();
            txtName.Text = obj.Name;
            txtFatherName.Text = obj.Father_s_Name;
            txtMotherName.Text = obj.Mother_s_Name;
            txtAddress.Text = obj.Address;
            cbxGender.SelectedText = obj.Gender_Id.ToString();
            txtPersonalContact.Text = obj.Personal_Contact.ToString();
            txtFatherContact.Text = obj.Father_s_Contact.ToString();
            txtMotherContact.Text = obj.Mother_s_Contact.ToString();
            dteBirthDate.Value = Convert.ToDateTime(obj.Birth_Date);
            cbxClass.SelectedText = obj.Class.ToString();
            txtRoll.Text = obj.Roll.ToString();
            txtInstitution.Text = obj.Institution;
            txtSection.Text = obj.Section;
            cbxSubject.SelectedText = obj.Subject_Id.ToString();
            dteAdmissionDate.Value = Convert.ToDateTime(obj.Admission_Date);
            pbxImage.Image = ConvertByteToImage(obj.Image);
        }

               
        
        
    }
}
