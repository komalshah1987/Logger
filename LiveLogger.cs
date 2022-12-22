using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LiveLogger:ILogger
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void LogError(Exception ex)
        {
            log.Error("Live Error:" + ex);
        }

        public void LogInfo(Exception ex)
        {
            log.Info("Live Error:" + ex);
        }
    }
}

