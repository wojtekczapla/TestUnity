using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity
{
    public class TestConstructorInjection : ITestConstructorInjection
    {
        ILogger logger;
        public TestConstructorInjection(ILogger log)
        {
            logger = log;
        }

        public void GetITestConstructorInjection(string param)
        {
            logger.Info(param);
        }
    }
}
