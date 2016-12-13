﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWcf_Service.service
{
    public static class SrvUtils
    {
        /// <summary>
        /// Замедляет работу основного потока на указанное количество секунд.
        /// </summary>
        /// <param name="seconds">Количество секунд задержки</param>
        /// <param name="stop">ссылка на ключ остановки службы</param>
        public static bool Retarder(int seconds, ref bool stop)
        {
            for (var i = 0; !stop && i < seconds * 1000 / Constants.TimeScanStopParam; i++)
            {
                Thread.Sleep(Constants.TimeScanStopParam);
            }
            return stop;
        }
    }
}
