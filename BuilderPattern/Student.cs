using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Student
    {
        int rollNo;
        String Name;
        int age;
        List<String> sub;
         public Student(StudentBuilder studentBuilder)
        {
            rollNo=studentBuilder.rollNo;
            Name = studentBuilder.Name;
            age = studentBuilder.age;
            sub = studentBuilder.sub;
        }
        public String ToString()
        {
            return "" + " roll number: " + this.rollNo +
                    " age: " + this.age +
                    " name: " + this.Name +
                    " subjects: " + sub[0] + "," + sub[1] + "," + sub[2];
        }



    }
}
