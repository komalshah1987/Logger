using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   static class LogFactory
    {
        public static ILogger GetLoggerInstance(string deploymentType)
        {
            switch (deploymentType)
            {
                case "dev":
                    return new DevLogger();
                case "live":
                    return new LiveLogger();
               
                default:
                    return null;
            }
        }
    }
}
