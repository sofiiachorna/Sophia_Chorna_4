using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public interface IDisk
    {
        string type();
        int getsize();
        void Launch();
        void Format();
    }
    public class Disk : IDisk
    {
        protected int size { get; set; }
        public string name { get; set; }

        protected List<directory> DirectoryList = new List<directory>();
        public Disk (string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public string type() => GetType().Name;
        public int getsize() => size;
       
        public virtual void Launch()
        {
            Console.WriteLine($"{name} successfully launched");
        }
        public virtual void Format()
        {
            Console.WriteLine($"{name} successfully formated");
        }

        public void AddDir(directory a)
        {
            this.DirectoryList.Add(a);
        }

        public void ShowDisk()
        {
            
            foreach(var i in DirectoryList)
            {
                Console.WriteLine($"Directory: {i.name}");
                i.ShowFiles();
            }
        }
    }
}
