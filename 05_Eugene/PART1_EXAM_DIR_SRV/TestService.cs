﻿using System;
using System.Threading;
using Common;

namespace PART1_EXAM_DIR_SRV
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    class TestService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;

        public void Start()
        {
            const string method = "Start";
            _thread = new Thread(x =>
            {
                do
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        var s = $"TestService: {i}";
                        Logger.Trace(method, s);
                        Console.WriteLine(s);
                        SrvUtils.Retarder(1, ref _stopFlag);
                    }
                } while (!SrvUtils.Retarder(30, ref _stopFlag));
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}