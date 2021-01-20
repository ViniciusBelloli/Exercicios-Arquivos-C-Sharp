using System;
using System.IO;

namespace Teoria3
{
   class Teoria3
   {
      static void Main(string[] args)
      {
         string path = @"C:\temp\file1.txt";

         try
         {
            using (StreamReader sr = File.OpenText(path))
            {
               while (!sr.EndOfStream)
               {
                  string line = sr.ReadLine();
                  Console.WriteLine(line);
               }
            }
         }
         catch (IOException e)
         {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
         }
      }
   }
}