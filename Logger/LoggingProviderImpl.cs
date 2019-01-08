using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.IO;
using NLog.Config;
using SampleLoggerByTarento.Common.Interfaces;

namespace SampleLoggerByTarento.Common
{
    public class LoggingProviderImpl :ILoggingProvider
    {
        private static readonly string LogFileConfigName = AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + @"bin\NLog.config";

        private Logger logger;
        //public LoggingProviderImpl()
        //    : this(ApplicationConstants.Application_Name)
        //{
        //}

        //TODO::Make this parameter configurable from client side.
        public LoggingProviderImpl(string className)
        {
            if (File.Exists(LogFileConfigName))
            {
                LoggingConfiguration nLogConfig = new XmlLoggingConfiguration(LogFileConfigName);
                LogManager.Configuration = nLogConfig;
                logger = LogManager.GetLogger(className);
            }
            else
                throw new IOException(string.Format("The configuration file at {0} is not available" + LogFileConfigName));
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            logger.Error(message, args);
        }

        public void Error(IFormatProvider format, string message, params object[] args)
        {
            logger.Error(format, message, args);
        }

        public void Error<T>(string message, T argument)
        {
            logger.Error<T>(message, argument);
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            logger.Error<T>(formatProvider, value);
        }

        public void Error<T>(IFormatProvider format, string message, T argument)
        {
            logger.Error<T>(format, message, argument);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            logger.Info(message, args);
        }

        public void Info(IFormatProvider format, string message, params object[] args)
        {
            logger.Info(format, message, args);
        }

        public void Info<T>(string message, T argument)
        {
            logger.Info<T>(message, argument);
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            logger.Info<T>(formatProvider, value);
        }

        public void Info<T>(IFormatProvider format, string message, T argument)
        {
            logger.Info<T>(format, message, argument);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            logger.Debug(message, args);
        }

        public void Debug(IFormatProvider format, string message, params object[] args)
        {
            logger.Debug(format, message, args);
        }

        public void Debug<T>(string message, T argument)
        {
            logger.Debug<T>(message, argument);
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            logger.Debug<T>(formatProvider, value);
        }

        public void Debug<T>(IFormatProvider format, string message, T argument)
        {
            logger.Debug<T>(format, message, argument);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            logger.Warn(message, args);
        }

        public void Warn(IFormatProvider format, string message, params object[] args)
        {
            logger.Warn(format, message, args);
        }

        public void Warn<T>(string message, T argument)
        {
            logger.Warn<T>(message, argument);
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            logger.Warn<T>(formatProvider, value);
        }

        public void Warn<T>(IFormatProvider format, string message, T argument)
        {
            logger.Warn<T>(format, message, argument);
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Fatal(string message, params object[] args)
        {
            logger.Fatal(message, args);
        }

        public void Fatal(IFormatProvider format, string message, params object[] args)
        {
            logger.Fatal(format, message, args);
        }

        public void Fatal<T>(string message, T argument)
        {
            logger.Fatal<T>(message, argument);
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            logger.Fatal<T>(formatProvider, value);
        }

        public void Fatal<T>(IFormatProvider format, string message, T argument)
        {
            logger.Fatal<T>(format, message, argument);
        }

        public void InfoException(string message, Exception exception)
        {
            logger.InfoException(message, exception);
        }

        public void DebugException(string message, Exception exception)
        {
            logger.DebugException(message, exception);
        }

        public void ErrorException(string message, Exception ex)
        {
            logger.ErrorException(message, ex);
        }

        public void FatalException(string message, Exception ex)
        {
            logger.FatalException(message, ex);
        }

        public void WarnException(string message, Exception ex)
        {
            logger.WarnException(message, ex);
        }
    }

}
