using System;
using System.IO;
using System.Collections.Generic;

namespace Teoria5
{
   class Teoria5
   {
      static void Main(string[] args)
      {
         string path = @"C:\temp\myfolder";

         try
         {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");

            foreach (string s in folders)
            {
               Console.WriteLine(s);
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("\nFILES:");

            foreach (string s in files)
            {
               Console.WriteLine(s);
            }

            Directory.CreateDirectory(path + @"\newfolder");
         }
         catch (IOException e)
         {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
         }
      }
   }
}