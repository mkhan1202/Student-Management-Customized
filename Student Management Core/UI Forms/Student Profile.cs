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
    public partial class Student_Profile : Form
    {
        public Student_Profile()
        {
            InitializeComponent();
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

        private void btnSearchProfile_Click(object sender, EventArgs e)
        {
            var db = new Core_StudyEntities();
            var obj = db.Student_Information.ToList().Where(x => x.Student_Id == Convert.ToInt32(txtSearchId.Text.ToString())).FirstOrDefault();

            lblName.Text = obj.Name;
            lblFname.Text = obj.Father_s_Name;
            lblMname.Text = obj.Mother_s_Name;
            lblBirthdate.Text = Convert.ToString(obj.Birth_Date);
            lblAddress.Text = obj.Address;
            lblPersonalContact.Text = obj.Personal_Contact.ToString();
            lblFcontact.Text = obj.Father_s_Contact.ToString();
            lblMcontact.Text = obj.Mother_s_Contact.ToString();
            lblRoll.Text = obj.Roll.ToString();
            lblInstitution.Text = obj.Institution;
            lblSection.Text = obj.Section;
            lblGender.Text = obj.Gender_Id.ToString();
            lblClass.Text = obj.Class.ToString();
            lblSubject.Text = obj.Subject_Id.ToString();
            pbxImage.Image = ConvertByteToImage(obj.Image);
            Show_Gender();
            Show_Class();
            Show_Subject();
            
        }

        private void Show_Subject()
        {
            if (lblSubject.Text == "1")
            {
                lblSubject.Text = "Business Studies";
            }

            else if (lblSubject.Text == "2")
            {
                lblSubject.Text = "Humanities";
            }

            else
            {
                lblSubject.Text = "Science";
            }
        }

        private void Show_Class()
        {
            if (lblClass.Text == "1")
            {
                lblClass.Text = "Class 3";
            }

            else if (lblClass.Text == "2")
            {
                lblClass.Text = "Class 4";
            }

            else if (lblClass.Text == "3")
            {
                lblClass.Text = "Class 5";
            }

            else if (lblClass.Text == "4")
            {
                lblClass.Text = "Class 6";
            }

            else if (lblClass.Text == "5")
            {
                lblClass.Text = "Class 7";
            }

            else if (lblClass.Text == "6")
            {
                lblClass.Text = "Class 8";
            }

            else if (lblClass.Text == "7")
            {
                lblClass.Text = "Class 9";
            }

            else if (lblClass.Text == "8")
            {
                lblClass.Text = "Class 10";
            }

            else if (lblClass.Text == "9")
            {
                lblClass.Text = "Inter 1st";
            }

            else if (lblClass.Text == "10")
            {
                lblClass.Text = "Inter 2nd";
            }
            
        }

        private void Show_Gender()
        {
            if (lblGender.Text == "1")
            {
                lblGender.Text = "Male";
            }

            else if (lblGender.Text == "2")
            {
                lblGender.Text = "Female";
            }

            else
            {
                lblGender.Text = "Others";
            }
        }
    }
}
