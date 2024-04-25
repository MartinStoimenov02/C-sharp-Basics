using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others
{
    internal class Delegates
    {
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");

        // call LogError method from LoggerHelper class
        public static void Log(string error)
        {
            logger.LogError(error);
        }

        public static void Log2(string error)
        {
            Console.WriteLine("- DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("- DELEGATES -");
        }

        // A delegate is a type that represents references to methods with a particular parameter list and return type.
        // When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
        // You can invoke (or call) the method through the delegate instance.
        //Delegates are used to pass methods as arguments to other methods.
        //Event handlers are nothing more than methods that are invoked through delegates.You create a custom method,
        //and a class such as a windows control can call your method when a certain event occurs.
        // In this case, ActionOnError method is called from Main code, to use Log method, and pass the error message
        public delegate void ActionOnError(string errorMessage);
    }
}
