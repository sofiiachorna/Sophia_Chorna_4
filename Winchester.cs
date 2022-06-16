using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public class Winchester : Disk
    {
        public Winchester(int size, string name) : base(name,size) { this.size = size; this.name = name; }
        protected List<Disk> disks = new List<Disk>();
        public void add(Disk a)
        {
            disks.Add(a);
        }
        public void Formatting ( Disk a,string name)
        {
            a = new Disk(a.name, 0);
            a.Format();
        }

        public void ShowAllFiles()
        {
            foreach(var i in disks)
            {
                i.ShowDisk();
            }
        }
    }

}
