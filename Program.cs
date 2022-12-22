using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {


        private static readonly log4net.ILog logTest =
         log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //log4Net_Init();
            
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            //logTest.Info("Hello logging world!");
            //logTest.Error("Error!");
            //logTest.Warn("Warn!");

            //Console.ReadLine();


            ILogger logger = LogFactory.GetLoggerInstance("dev");
            try
            {
                throw new Exception("This is error message");
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }

        }

        static void log4Net_Init()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
        }
    }
}
