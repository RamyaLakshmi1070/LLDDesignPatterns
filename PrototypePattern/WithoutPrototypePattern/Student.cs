using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.WithoutPrototypePattern
{
    class Student
    {
        public int rollNo;
        public String Name;
        private long phoneNumber;

        public Student()
        {
        }

        public Student(int rollNo, string name, long phoneNumber)
        {
            this.rollNo = rollNo;
            Name = name;
            this.phoneNumber = phoneNumber;
        }
    }
}
