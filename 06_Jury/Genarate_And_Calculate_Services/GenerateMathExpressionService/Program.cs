﻿using System;
using System.IO;
using System.ServiceProcess;
using Common;
using GenerateMathExpressionService.service;

namespace GenerateMathExpressionService
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += UnhandledExceptionHandler;
            Initlog();
            var svc = new MainService();
            if (Array.IndexOf(args, "console") != -1 || Array.IndexOf(args, "c") != -1)
            {
                svc.StartSvc();
                Console.WriteLine("Press a key for exit...");
                Console.ReadKey(true);
                svc.StopSvc();
                Logger.Write(Level.Info, "Остановка сервера");
            }
            else
            {
                ServiceBase.Run(svc);
            }
        }
        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            const string method = "UnhandledExceptionHandler";
            var ex = (Exception)args.ExceptionObject;
            Console.WriteLine(ex == null ? "Error!" : $"{method}\n{ex}");
        }

        private static void Initlog()
        {
            #region Инициализация логгера

            Logger.Level = Config.Get.Log.Level;

            // Определение пути доступа к журналу событий

            try
            {
                Logger.Dir = Config.Get.Log.Dir;
                Directory.CreateDirectory(Logger.Dir); // если каталог не существует - создаст
            }
            catch
            {
               
            }

            Logger.Prefix = Config.Get.Log.Prefix;
            Logger.Start();
            Logger.Write(Level.Info, "Старт сервера");

            #endregion

        }

    }
}
