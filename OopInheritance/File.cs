using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class File
    {
        public File(string name, string extension)
        {
            Name = name;
            Extension = extension;
        }

        public string Name
        {
            get;
        }

        public string Extension
        {
            get;
        }

        public void Open()
        {
            Console.WriteLine($"Opening file '{this.Name}.{this.Extension}'");
        }
    }
}
