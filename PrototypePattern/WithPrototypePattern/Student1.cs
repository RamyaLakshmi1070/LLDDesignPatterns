namespace PrototypePattern.WithPrototypePattern
{
    public class Student1 : Prototype
    {
        public int rollNo;
        public String Name;
        private long phoneNumber;

        public Student1()
        {
        }

        public Student1(int rollNo, string name, long phoneNumber)
        {
            this.rollNo = rollNo;
            Name = name;
            this.phoneNumber = phoneNumber;
        }

        public Student1 Clone() => this;
    }
}