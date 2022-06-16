using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public class archive : File
    {
        public archive(int size, string name) : base(size, name) { this.size = size; this.name = name; }

        public override void Launch()
        {
            Console.WriteLine($"You cannot launch an archive");
        }
    }
}
