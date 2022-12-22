using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface ILogger
    {
        void LogError(Exception ex);
        void LogInfo(Exception ex);
    }
}
