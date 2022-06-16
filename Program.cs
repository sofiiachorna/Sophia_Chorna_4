using System;

namespace Lab_4_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Winchester w = new Winchester(1600, "C");
            Disk c = new Disk("C", 800);
            Disk d = new Disk("D", 800);
          
            directory dir = new directory(800, "files");



            dir.add(new mp3(5, "Adele - Rolling in the deep.mp3"));
            dir.add(new archive(150, "Photos.rar"));
            dir.add(new archive(5000, "FlappyBird.exe"));
            dir.add(new mp3(3000, "Music.mp3"));
            dir.add(new mp3(10000, "song.mp3"));

            c.AddDir(dir);
            w.add(c);
            
            Console.WriteLine("The amount of mp3 files in directory: "+dir.countmp3());

            dir.GetAllTypes();
            Console.WriteLine("Input the name of file you want to launch:");
            string a = Console.ReadLine();
            dir.LaunchFile(a);

            Console.WriteLine($"Directoty {dir.name} has size {dir.getsize()} and length {dir.getLength()}");

            w.ShowAllFiles();
        }
    }
}
