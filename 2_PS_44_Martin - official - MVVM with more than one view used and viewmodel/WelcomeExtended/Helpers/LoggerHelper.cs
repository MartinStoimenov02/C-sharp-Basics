using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    internal static class LoggerHelper
    {
        public static Microsoft.Extensions.Logging.ILogger GetLogger(string categoryName)
        {
            // create instance of LoggerFactory class(standard class in ILogger interface)
            var loggerFactory = new LoggerFactory();
            // Adds the specified provider to the collection of providers used in creating ILogger instances.
            loggerFactory.AddProvider(new LoggerProvider()); //Add LoggerProvider class as Provider for the factory

            return loggerFactory.CreateLogger(categoryName); //call CreateLogger from LoggerProvider class
        }
    }
}
