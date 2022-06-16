using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public abstract class File
    {
        public int size { get; set; }
        public string name { get; set; }
        public File (int size, string name) 
        { 
            this.size = size;
            this.name = name;
        }
        public virtual void Launch()
        {
            Console.WriteLine($"File {name} successfully launched");
        }
        
    }

}
