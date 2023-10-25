using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Core
{
    class Manage
    {
        public List<Gender_Info> GetAllGender()
        {
            var obj = new Core_StudyEntities();
            var q = from g in obj.Gender_Info
                    select g;
            return q.ToList();
        }

        public List<Class_Info> GetAllClass()
        {
            var obj = new Core_StudyEntities();
            var q = from c in obj.Class_Info
                    select c;
            return q.ToList();
        }

        public List<Subject_Info> GetAllSubject()
        {
            var obj = new Core_StudyEntities();
            var q = from s in obj.Subject_Info
                    select s;
            return q.ToList();
        }

        public List<Student_View> GetAllStudentData()
        {
            var obj = new List<Student_View>();
            var context = new Core_StudyEntities();
            var q = from student in context.Student_Information
                    join gdr in context.Gender_Info on student.Gender_Id equals gdr.Gender_Id
                    join cls in context.Class_Info on student.Class equals cls.Class_Id
                    join sbj in context.Subject_Info on student.Subject_Id equals sbj.Subject_Id
                    select new
                    {
                        student.Student_Id,
                        student.Name,
                        student.Father_s_Name,
                        student.Mother_s_Name,
                        student.Address,
                        gdr.Gender_Type,
                        student.Personal_Contact,
                        student.Father_s_Contact,
                        student.Mother_s_Contact,
                        student.Birth_Date,
                        cls.Class_Name,
                        student.Roll,
                        student.Institution,
                        student.Section,
                        sbj.Subject_Name,
                        student.Admission_Date,
                        student.Image
                    };

            foreach (var item in q)
            {
                var stv = new Student_View();
                stv.Student_Id = item.Student_Id;
                stv.Name = item.Name;
                stv.Father_Name = item.Father_s_Name;
                stv.Mother_Name = item.Mother_s_Name;
                stv.Address = item.Address;
                stv.Gender = item.Gender_Type;
                stv.Personal_Contact = item.Personal_Contact;
                stv.Father_Contact = item.Father_s_Contact;
                stv.Mother_Contact = item.Mother_s_Contact;
                stv.Birth_Date = item.Birth_Date;
                stv.Class = item.Class_Name;
                stv.Roll = item.Roll;
                stv.Institution = item.Institution;
                stv.Section = item.Section;
                stv.Subject = item.Subject_Name;
                stv.Admission_Date = item.Admission_Date;
                obj.Add(stv);

            }

            return obj.ToList();
        }

        public List<Student_View> GetDataBySearch(int a, int b, int c)
        {
            var obj = new List<Student_View>();
            var context = new Core_StudyEntities();
            var q = from student in context.Student_Information
                    join gdr in context.Gender_Info on student.Gender_Id equals gdr.Gender_Id
                    join cls in context.Class_Info on student.Class equals cls.Class_Id
                    join sbj in context.Subject_Info on student.Subject_Id equals sbj.Subject_Id
                    where student.Gender_Id == a || student.Class == b || student.Subject_Id == c
                    select new
                    {
                        student.Student_Id,
                        student.Name,
                        student.Father_s_Name,
                        student.Mother_s_Name,
                        student.Address,
                        gdr.Gender_Type,
                        student.Personal_Contact,
                        student.Father_s_Contact,
                        student.Mother_s_Contact,
                        student.Birth_Date,
                        cls.Class_Name,
                        student.Roll,
                        student.Institution,
                        student.Section,
                        sbj.Subject_Name,
                        student.Admission_Date,
                        student.Image
                    };

            foreach (var item in q)
            {
                var stv = new Student_View();
                stv.Student_Id = item.Student_Id;
                stv.Name = item.Name;
                stv.Father_Name = item.Father_s_Name;
                stv.Mother_Name = item.Mother_s_Name;
                stv.Address = item.Address;
                stv.Gender = item.Gender_Type;
                stv.Personal_Contact = item.Personal_Contact;
                stv.Father_Contact = item.Father_s_Contact;
                stv.Mother_Contact = item.Mother_s_Contact;
                stv.Birth_Date = item.Birth_Date;
                stv.Class = item.Class_Name;
                stv.Roll = item.Roll;
                stv.Institution = item.Institution;
                stv.Section = item.Section;
                stv.Subject = item.Subject_Name;
                stv.Admission_Date = item.Admission_Date;
                obj.Add(stv);

            }

            return obj.ToList();
        
        }
    }
}
