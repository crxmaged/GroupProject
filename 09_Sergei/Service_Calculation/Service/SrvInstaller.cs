﻿using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;

namespace Service_Calculation.Service
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
            _serviceInstaller.Description = "Service Calculation SRV";
            _serviceInstaller.StartType = ServiceStartMode.Automatic;

            Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
            
        }
    }
}
