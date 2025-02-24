namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory("Movie Industry");
            File file = new File("India Films");
            directory.Add(file);

            Directory directory1 = new Directory("HollyWood");
            File file1 = new File("Spider Man 1");
            directory1.Add(file1);

            directory.Add(directory1);

            directory.ls();


        }
    }
}
