﻿//пример взят с сайта http://professorweb.ru

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace _403_Hashtable
{
    class Program
    {
        private static User _user;

        static void Main(string[] args)
        {
            //ClassWork();
            //HashtableMethod();
            //SordedListMethod();
            //BitArrayMethod();
            _user = new User();
            _user.ChangeWork += UserOnChangeWork();
            _user.ChangeWork += x => { Console.WriteLine("x2: " + x); };
            _user.ChangeWork += Action;

            ThreadPool.QueueUserWorkItem(CallBack, ConsoleColor.Red);
            Thread.Sleep(100);
            ThreadPool.QueueUserWorkItem(CallBack, ConsoleColor.Green);
            Thread.Sleep(100);

            Console.ReadKey();
        }

        private static void Action(string obj)
        {
            Console.WriteLine("x3: " + obj);
        }

        private static Action<string> UserOnChangeWork()
        {
            return x => { Console.WriteLine("x1: " + x); };
        }

        private static void CallBack(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                ConsoleColor color = (ConsoleColor) o;
                Console.ForegroundColor = color;
                _user.OnChangeWork(Enum.GetName(typeof(ConsoleColor), color));
            }
        }

        private static void ClassWork()
        {
            int count = 10;
            string pathDir = "Out";
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
            for (int i = 0; i < count; i++)
            {
                string fileName = Guid.NewGuid().ToString("N").ToUpper();
                var pathFile = Path.Combine(pathDir, fileName);
                File.WriteAllText(pathFile + ".txt", fileName);
            }

            var directoryInfo = new DirectoryInfo(pathDir);
            List<FileInfo> fileInfos = directoryInfo.GetFiles().ToList();
            var infos = fileInfos.OrderBy(x => x.CreationTime).ToList();
            Delete(infos);
        }

        private static void Delete(List<FileInfo> infos)
        {
            var l = 5;
            for (int i = 0; i < l && infos.Count > l; i++)
            {
                var path = infos[i].FullName;
                File.Delete(path);
            }
        }

        private static void BitArrayMethod()
        {
            BitArray bits1 = new BitArray(10);
            BitArray bits2 = new BitArray(10);
            bits1.SetAll(false);
            bits1.Set(2, true);
            bits1[3] = true;
            bits1[8] = true;

            bits2 = bits1;
            bits1 = bits1.Not();
            Console.Write("bits1: ");
            WriteBits(bits1);
            Console.Write("bits2: ");
            WriteBits(bits2);

            Console.Write("NOT(bits1): ");
            bits1.Not();
            WriteBits(bits1);

            Console.Write("bits1 AND bits2: ");
            bits1.And(bits2);
            WriteBits(bits1);

            Console.ReadLine();
        }

        static void WriteBits(BitArray bits)
        {
            foreach (bool b in bits)
                Console.Write(b ? 1 : 0);
            Console.WriteLine("\n");
        }

        private static void HashtableMethod()
        {
            Hashtable ht = new Hashtable();

            // Добавим несколько записей
            ht.Add("alex85", "12345");
            ht.Add("fg230404", "12ldsd");
            ht.Add("I_best_user", "12349");

            // Считаем коллекцию ключей 
            ICollection keys = ht.Keys;

            foreach (string s in keys)
                Console.WriteLine(s + ": " + ht[s]);

            Console.ReadLine();
        }

        private static void SordedListMethod()
        {
            // Создадим коллекцию сортированного списка

            SortedList<string, string> UserInfo = new SortedList<string, string>();

            // Добавим несколько элементов в коллекию
            UserInfo.Add("Zack", "12345");
            UserInfo.Add("Den", "12345");
            UserInfo.Add("Alex", "12345");
            UserInfo.Add("John", "12345");
            UserInfo.Add("Elhm", "12345");
            UserInfo.Add("Lamar", "12345");


            // Коллекция ключей
            ICollection<string> keys = UserInfo.Keys;

            // Теперь используем ключи, для получения значений
            foreach (string s in keys)
                Console.WriteLine("User: {0}, Password: {1}", s, UserInfo[s]);

            Console.ReadLine();
        }
    }
}