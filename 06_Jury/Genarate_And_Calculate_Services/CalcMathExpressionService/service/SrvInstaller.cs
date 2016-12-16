﻿using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;


namespace CalcMathExpressionService.service
{
    [RunInstaller(true)]
    public class SrvInstaller : Installer
    {
        private readonly ServiceProcessInstaller _serviceProcessInstaller;
        private readonly ServiceInstaller _serviceInstaller;

        public SrvInstaller()
        {
            _serviceProcessInstaller = new ServiceProcessInstaller();
            _serviceInstaller = new ServiceInstaller();

            _serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

            _serviceInstaller.ServiceName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.DisplayName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.Description = "Cервис - Калькулятор арифметических выражений считанных с файла";
            _serviceInstaller.StartType = ServiceStartMode.Automatic;

            Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
        }
    }
}