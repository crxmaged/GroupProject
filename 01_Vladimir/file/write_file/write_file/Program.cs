﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace write_file
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            for (int i = 0; i <count; i++)
            {
                string path = @"c:\temp\MyTest.txt";

                // This text is added only once to the file. // Створіть файл для запису.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    string createText = "Hello and Welcome" + Environment.NewLine;
                    File.WriteAllText(path, createText);
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                string appendText = "This is extra text" + Environment.NewLine;
                File.AppendAllText(path, appendText);

                // Open the file to read from.
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
                //File.WriteAllText(path, text);
            }
        }
    }
}
