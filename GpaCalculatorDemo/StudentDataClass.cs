using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalculatorDemo
{
    class StudentDataClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StuId { get; set; }
        public int Semester { get; set; }
        public string Campus { get; set; }
        public double Course1 { get; set; }
        public double Course2 { get; set; }
        public double Course3 { get; set; }
        public double Course4 { get; set; }
        public double Credits { get; set; }
        public double GPA { get; set; }



        public StudentDataClass(string firstname,string lastname, int stuid, int semester, string campus
                               ,double course1,double course2, double course3, double course4, double credits, double gpa)
        {
            FirstName = firstname;
            LastName = lastname;
            StuId = stuid;
            Semester = semester;
            Campus = campus;
            Course1 = course1;
            Course2 = course2;
            Course3 = course3;
            Course4 = course4;
            Credits = credits;
            GPA = gpa;
        }
        public static List<StudentDataClass> GetStudents()
            => new List<StudentDataClass>()
            {
                new StudentDataClass("Demario","Douce",5632712,1,"Main",100,100,100,100,4,4.0),
                new StudentDataClass("Aston","Lee",5632212,2,"Other",50,50,100,100,4,4.0),
                new StudentDataClass("Joy","Ton",323121,3,"Other",10,10,10,10,4,1.0),
                new StudentDataClass("Manhan","Ruth",1231234,4,"Main",20,20,20,20,2,1.0),

            };
    }
}
