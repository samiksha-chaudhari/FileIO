using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIO_Demo
{
    class Read
    {
        //By using strem reader inbuild class

        /// <summary>
        /// method to write or Append text in existing file
        /// </summary>
        public void WriteUsingStreamWriter()
        {
            String path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\n Hello everyone.. My name is Samiksha");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

        /// <summary>
        /// method to read the line from file
        /// </summary>
        public void ReadFromStreamReader()
        {
            String path = @"D:\new1\bridgelabz_fellowship\FileIO_Demo\FileIO_Demo\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
