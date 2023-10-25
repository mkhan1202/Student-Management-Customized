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
    public partial class View_Student_Info : Form
    {
        public View_Student_Info()
        {
            InitializeComponent();
        }

        private void View_Student_Info_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            var mn = new Manage();
            var data = mn.GetAllStudentData();

            dgvAllStudentInfo.DataSource = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var printer = new DGVPrinter();
            printer.Title = "Core Study Point";
            printer.SubTitle = "Student List";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dgvAllStudentInfo);
            
        }
    }
}
