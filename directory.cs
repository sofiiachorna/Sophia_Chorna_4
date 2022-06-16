using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
   public class directory : Disk
    {
        protected List<File> FileList = new List<File>();
        public directory(int size, string name) : base(name, size) 
        {
            this.size = size;
            this.name = name;
        }

        public void add(File a)
        {
            FileList.Add(a);
        }

        public int getLength() => FileList.Count;

        public void GetAllTypes()
        {
            foreach (var i in FileList)
            {
                Console.WriteLine($"{i.name} - {i.GetType().Name}");
            }
        }
        public int countmp3()
        {
            int count = 0;
            foreach (var i in FileList)
            {
                if (i.GetType().Name == "mp3")
                { count++; }

            }
            return count;
        }

        public void LaunchFile(string name)
        {
            foreach(var i in FileList)
            {
                if(i.name.Contains(name)==true)
                {
                    i.Launch();
                }
            }
        }

        public void ShowFiles()
        {
            foreach(var i in FileList)
            {
                Console.WriteLine($"{i.name}");
            }
        }
        
    }
}
