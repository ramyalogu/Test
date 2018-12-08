using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public interface IFileSystemWriter
    {
        void WriteToFile(string input);
    }

    public interface IDummy
    {
        void WriteToConsole(string input);
    }

    public class FileSystemWriter : IFileSystemWriter, IDummy
    {
        /// <summary>
        /// Writes to a file, creates file if it does not exist
        /// Otherwise overwrites the existing file
        /// </summary>
        /// <param name="input"></param>
        public void WriteToFile(string input)
        {
            File.WriteAllText(@"C:\code\dummy.txt", input);
        }

        public void WriteToConsole(string input)
        {
            Console.WriteLine(input);
        }
    }

    public static class GlobalWriter
    {
        public static void WriteFile(string input)
        {
            File.WriteAllText(@"C:\code\dummy.txt", input);
        }
    }

}
