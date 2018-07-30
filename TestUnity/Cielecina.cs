using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnity
{
    public class Cielecina : ITestComponent
    {
        ILogger logger;

        public Cielecina(ILogger log)
        {
            logger = log;
        }

        public void GetName()
        {
            logger.Warn("Cielecina Log");
        }
    }
}
