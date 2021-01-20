using System;
using System.IO;


namespace Teoria4
{
   class Teoria4
   {
      static void Main(string[] args)
      {
         string sourcePath = @"C:\temp\file1.txt";
         string targetPath = @"C:\temp\file2.txt";

         try
         {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
               foreach (string line in lines)
               {
                  sw.WriteLine(line.ToUpper());
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
