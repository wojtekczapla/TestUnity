using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity
{
    public class Baranina : ITestComponent
    {
        ILogger logger;
        ITestConstructorInjection testConstructorInjection;

        public Baranina(ILogger log, ITestConstructorInjection testConstructorInjection)
        {
            logger = log;
            this.testConstructorInjection = testConstructorInjection;
        }

        public void GetName()
        {
            logger.Warn("Baranina Log");
            this.testConstructorInjection.GetITestConstructorInjection("GetITestConstructorInjection");
        }
    }
}
