using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Directory
    {
        private readonly StudentBuilder student1;
        public Directory(StudentBuilder student)
        {
            this.student1 = student;
        }

        public Student CreateStudent()
        {
            if (student1 is MBAStudent)
            {
                return CreateMBAStudent();
            }
            else
            {
                return CreateEngineeringStudent();
            }
        }

        private Student CreateEngineeringStudent()
        {
            return student1.SetRollNo(1001).SetName("Sheela").SetAge(20).setSubjects().Build();
        }

        private Student CreateMBAStudent()
        {
            return student1.SetRollNo(1001).SetName("Sheela").SetAge(20).setSubjects().Build();
        }
    }
}
