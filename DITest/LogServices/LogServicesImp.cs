using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogServices
{
    public class LogServicesImp : LogProvider
    {
        public void LoggError(string error)
        {
            Console.WriteLine($"error{error}");
        }

        public void LoggInfo(string msg)
        {
            Console.WriteLine($"info{msg}");
        }
    }
}
