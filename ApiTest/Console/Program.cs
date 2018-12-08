using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.Console.ReadLine();
            IFileSystemWriter writer = new FileSystemWriter();
            writer.WriteToFile(input);
            GlobalWriter.WriteFile(input);
            System.Console.Read();
        }
    }
}
