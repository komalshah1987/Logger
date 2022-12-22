using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DevLogger : ILogger
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void LogError(Exception ex)
        {
            log.Error("Dev Error:" + ex);
        }

        public void LogInfo(Exception ex)
        {
            log.Info("Dev Error:" + ex);
        }
    }
}
