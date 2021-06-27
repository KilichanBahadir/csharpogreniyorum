using System;
using System.Collections.Generic;
using System.Text;

namespace works24
{
    public class Student
       
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }
}
