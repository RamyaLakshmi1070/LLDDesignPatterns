﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class File : IFileSystem
    {
        String name;
        public File(String name)
        {
            this.name = name;  
        }
        public void ls()
        {
            Console.WriteLine("File System "+name);
        }
    }
}
