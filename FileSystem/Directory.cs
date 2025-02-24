using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Directory : IFileSystem
    {
        String directoryName;
        List<IFileSystem> lst;
        public Directory(String Name)
        {
            directoryName = Name;
            lst = new List<IFileSystem>();
            
        }
        public void Add(IFileSystem fileSystem)
        {
            lst.Add(fileSystem);
        }
        public void ls()
        {
            Console.WriteLine("Directory Name "+directoryName);
            foreach(IFileSystem file in lst)
            {
                file.ls();
            }
        }
    }
}
