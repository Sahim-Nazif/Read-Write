using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Writefile("Naz.txt");
            Readfile("Naz.txt");
        }
       public static void Writefile(string filename)
        {
            StreamWriter write = new StreamWriter(filename);
            write.WriteLine("Hi, Today You Created Write and Read File with System Input and Oupt");
            write.Close();
        }
        public static void Readfile(string filename)
        {
            StreamReader read = new StreamReader(filename);
            Console.WriteLine(read.ReadToEnd());
            read.Close();

        }
    }
}
