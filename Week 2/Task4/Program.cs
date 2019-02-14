using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string fileName = "as.txt"; // saveing file name to string filename
                string Path = @"C:\Users\A5LAN\Desktop\ppp\path"; 
                string Path1 = @"C:\Users\A5LAN\Desktop\ppp\path1";
                string sourceFile = System.IO.Path.Combine(Path, fileName);
                string destFile = System.IO.Path.Combine(Path1, fileName);
                if (!System.IO.Directory.Exists(Path1))
                {
                    System.IO.Directory.CreateDirectory(Path1);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                if (System.IO.Directory.Exists(Path))
                {
                    string[] files = System.IO.Directory.GetFiles(Path);


                    foreach (string s in files)
                    {

                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(Path1, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Исходный путь не существует!");
                }

                if (System.IO.File.Exists(@"C:\Users\A5LAN\Desktop\ppp\path\as.txt")) //checking to exiting of file
                {

                    try
                    {
                        System.IO.File.Delete(@"C:\Users\A5LAN\Desktop\ppp\path\as.txt");//delete the txt file from previous path
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }




              
            }
        }

    }
}
