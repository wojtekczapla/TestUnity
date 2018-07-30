namespace TestUnity
{
    using NLog;
    using System;

    public class Class1
    {
        ILogger logger;
        public Action GetName;

        public Class1(ILogger log)
        {
            logger = log;    
        }

        public void TestLogging()
        {
            logger.Debug("Test message");

            if(GetName != null)
                GetName.Invoke();
        }
    }
}
