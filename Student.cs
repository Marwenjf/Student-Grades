using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

namespace Student_Grades
{   
    [Serializable]
    public class Student
    {   
        private string studentId;
        private string firstName;
        private string lastName;
        private string studentClass;
        private string studentGrade;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentClass
        {
            get { return studentClass; }
            set { studentClass = value; }
        }

        public string StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }

        public Student(string id, string firstName,string lastName, string studentClass, string studentGrade)
        {
            this.studentId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentClass = studentClass;
            this.studentGrade = studentGrade;
        }
        public Student()
        {
            
        }

        public override string ToString()
       {
           return this.lastName+", "+this.firstName+": "+this.studentId+" \""+this.studentClass+"\" \""+this.studentGrade+"\"";
       }
    }
}