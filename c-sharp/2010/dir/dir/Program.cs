using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dir
{
    class Program
    {
        static void Main(string[] args)
        {
        string path = @"C:\Users\portatil\Music\";
        if (args.Length > 0)
        {
            if (File.Exists(args[0]))
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("{0} not found; using current directory:", args[0]);
            }
        }
        string fic = path + @"info.txt";
        System.IO.StreamWriter sw = new System.IO.StreamWriter(fic);
        DirectoryInfo dir = new DirectoryInfo(path);
        foreach (FileInfo f in dir.GetFiles("*.mp3")) 
        {
            String name = f. Name;
            long size = f.Length;
            DateTime creationTime = f.CreationTime;
            //Console.WriteLine("{0,-10:N0} {1,-17:g} {2}", size, creationTime, name);
            name = name.Replace(".mp3","");
            Console.WriteLine(name);
            sw.WriteLine(name);
        }
            sw.Close();
        Console.ReadKey();
        }
    }
    }

