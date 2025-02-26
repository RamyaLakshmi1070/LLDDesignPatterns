using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class StudentBuilder
    {
        public int rollNo;
        public String Name;
        public int age;
        public List<String> sub;

        public StudentBuilder SetRollNo(int rollNo)
        {
            this.rollNo = rollNo;
            return this;
        }
        public StudentBuilder SetName(String Name)
        {
            this.Name = Name;
            return this;
        }
        public StudentBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }
        abstract public StudentBuilder setSubjects();
        public Student Build()
        {
            return new Student(this);
        }
    }
}
