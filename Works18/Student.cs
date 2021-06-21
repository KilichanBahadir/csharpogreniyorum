using System;
using System.Collections.Generic;
using System.Text;

namespace Works18
{
    public class Student
    { 
        public int StudentNumber { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student()
        {

        }
        public Student(int _studentNumber, string _firstName, string _lastName)
        {
            this.StudentNumber = _studentNumber;
            this.FirstName = _firstName;
            this.LastName = _lastName;

        }
        public string StringYap()
        {
            string studentString = this.StudentNumber + "-" + this.FirstName + " " + this.LastName;
            return studentString;

        }
    }

}
