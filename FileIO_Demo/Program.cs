using System;
using System.IO;

namespace FileIO_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO demo");
            //Program.FileExists();
            //Program.ReadAllLines();
            //Program.ReadAllText();
            //Program.FileCopy();
            //Program.DeleteFile();
            Read readstream = new Read();
            //readstream.WriteUsingStreamWriter();
            readstream.ReadFromStreamReader();
        }

        /// <summary>
        /// method to chek file exits at the path or not
        /// </summary>
        public static void FileExists()
        {
            String path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists at given path");
            }
        }

        /// <summary>
        /// method to read file text by line
        /// </summary>
        public static void ReadAllLines()
        {
            String path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
        }

        /// <summary>
        /// method to read all text from file
        /// </summary>
        public static void ReadAllText()
        {
            String path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
        /// <summary>
        /// method to copy one file text to other file
        /// </summary>
        public static void FileCopy()
        {
            string path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";
            string copypath = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example1.txt";

            File.Copy(path, copypath);

        }
        /// <summary>
        /// method to delete file from given path 
        /// </summary>
        public static void DeleteFile()
        {
            string path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example1.txt";

            File.Delete(path);

        }
    }
}
