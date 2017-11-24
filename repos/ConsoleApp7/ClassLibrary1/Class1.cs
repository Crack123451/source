using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceFileSystem
{
    public class File
    {
        public File(string name)
        {
            Name = name;
        }

        public File(string name, double val)
        {

        }
        public double Value;
        public string Name;

        public void SetValue(double fileValue)
        {
            Value = fileValue;
        }

    }
    public class Directory
    {
        public string Name;
        public string ParentDirectory;
        public List<File> Files = new List<File>();
        public string Directories;

        public Directory(string name)
        {
            var list = new List<string>();
            Name = name;
        }

        public List<Directory> SubDirs { get; set; }

        public void AddDirectory(Directory subDir)
        {
            throw new NotImplementedException();
        }

        public File AddFile(string name)
        {
            return new File(name);
        }
    }
    public class FileSystem
    {
        public string RootDirectory;
    }
}
