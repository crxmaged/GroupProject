﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_vo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);

            for (var i = 0; i < 60; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
            Console.WriteLine();
            
            for (var i = 0; i < 49; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("***");
            Console.WriteLine();

            for (var i = 0; i < 48; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*****");
            Console.WriteLine();

        }
    }
}
