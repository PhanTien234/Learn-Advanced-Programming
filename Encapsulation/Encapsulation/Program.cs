using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace Encapsulation
{
    public class Program
    {
       
       public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name= "Tien";
            student.Age = 20;
            student.Gender = "Nam";
            student.Major = "IT";
            student.MidtermGrade = 9;
            student.FinalGrade = 10;
            student.AssignmentGrade = 7;
            GetStudent();
            

        }
        static void GetStudent()
        {
            Student student = new Student();
            Console.WriteLine("ID:");
           

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
        }


    }
    internal class Student
    {
        private string id;
        public string ID { get; set;  }
        private string name;
        public string Name { get; set; }
        private int age;
        public int Age { get; set; }
        private string gender;
        public string Gender { get; set; }
        private string major;
        public string Major { get; set; }
        private int midtermGrade;
        public int MidtermGrade { get; set; }
        private int finalGrade;
        public int FinalGrade { get; set; }
        private int assignmentGrade;
        public int AssignmentGrade { get; set; }
        private float averangeGade;
        public float AverangeGrade { get; set; }
        public Student()
        {
            ID = "GCD1001";
        }
        public Student
            (string id, string name, int age, string gender, string major, int midtermGrade, int finalGrade, int assignment, float averangeGrade)
        {
            this.ID = "GCD2019";
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Major = major;
            this.MidtermGrade = midtermGrade;
            this.FinalGrade = finalGrade;
            this.AssignmentGrade = assignment;
            this.AverangeGrade = averangeGrade;
        }


    }
}

