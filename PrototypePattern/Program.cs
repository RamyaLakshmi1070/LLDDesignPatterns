using PrototypePattern.WithoutPrototypePattern;
using PrototypePattern.WithPrototypePattern;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Without Prototye Pattern");
            Student student = new Student(101, "Ray", 90827478939);
            Student cloneStudent1 = new Student();
            cloneStudent1.rollNo = student.rollNo;
            cloneStudent1.Name = student.Name;
            Console.WriteLine("Since Phonenumber is private unable to clone it");

            Console.WriteLine("With Prototype Pattern");
            Student1 student1 = new Student1(102, "Ross", 90827478939);
            Student1 cloneStudent2 = new Student1();
            cloneStudent2 = (Student1)student1.Clone();
            Console.WriteLine("Cloned Successfully");


        }
    }
}
