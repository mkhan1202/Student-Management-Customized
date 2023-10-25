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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var obj = new Add_Student_Info() 
            { 
                TopLevel = false, 
                TopMost = true, 
                WindowState= FormWindowState.Maximized,
                FormBorderStyle= FormBorderStyle.None
            };
            pnlMain.Controls.Add(obj);
            obj.Show();
            
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            
            var obj = new Edit_Student_Info()
            {
                TopLevel = false,
                TopMost = true,
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None
            };
            pnlMain.Controls.Add(obj);
            obj.Show();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            var obj = new View_Student_Info()
            {
                TopLevel = false,
                TopMost = true,
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None
            };
            pnlMain.Controls.Add(obj);
            obj.Show();
        }
        

        private void btnStudentProfile_Click(object sender, EventArgs e)
        {
            var obj = new Student_Profile()
            {
                TopLevel = false,
                TopMost = true,
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None
            };
            pnlMain.Controls.Add(obj);
            obj.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var obj = new Search_Student()
            {
                TopLevel = false,
                TopMost = true,
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None
            };
            pnlMain.Controls.Add(obj);
            obj.Show();
        }
    }
}
