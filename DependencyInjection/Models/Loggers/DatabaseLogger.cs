using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models.Loggers
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Debug.WriteLine("logged with DatabaseLogger");
        }
    }
}