﻿using System;

[assembly:log4net.Config.XmlConfigurator]

namespace MultipleConfiguration
{
    class Program
    {
        static void Main()
        {
            log4net.Config.BasicConfigurator.Configure();

            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
            log.Error("Error");
            log.Fatal("Fatal");

            Console.ReadLine();
        }
    }
}
