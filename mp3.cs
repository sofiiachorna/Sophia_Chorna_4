using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public class mp3 : File
    {
        public mp3(int size, string name) : base(size, name) { this.size = size; this.name = name; }
        public override void Launch()
        {
            Console.WriteLine($"Mp3 file {name} successfully launched");
        }
    }
    

}
