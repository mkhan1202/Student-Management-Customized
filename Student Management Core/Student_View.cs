using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Core
{
    class Student_View
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Personal_Contact { get; set; }
        public string Father_Contact { get; set; }
        public string Mother_Contact { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Class { get; set; }
        public int Roll { get; set; }
        public string Institution { get; set; }
        public string Section { get; set; }
        public string Subject { get; set; }
        public DateTime Admission_Date { get; set; }
        
    }
}
