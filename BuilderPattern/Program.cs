namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Directory directory1 = new Directory(new MBAStudent());
           Student student= directory1.CreateStudent();
            Console.WriteLine(student.ToString()); 
            Directory directory2 = new Directory(new EngineeringStudent());
            Student student2 = directory2.CreateStudent();
            Console.WriteLine(student2.ToString());
        }
    }
}
