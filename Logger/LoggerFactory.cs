using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleLoggerByTarento.Common.Interfaces;

namespace SampleLoggerByTarento.Common
{
    public class LoggerFactory
    {
        public static ILoggingProvider GetLogger(string className)
        {
            return new LoggingProviderImpl(className);
        }
    }
}
