using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleLoggerByTarento.Common.Interfaces
{
    public interface ILoggingProvider
    {
        void Error(string message);
        void Error(string message, params object[] args);
        void Error(IFormatProvider format, string message, params object[] args);
        void Error<T>(string message, T argument);
        void Error<T>(IFormatProvider formatProvider, T value);
        void Error<T>(IFormatProvider format, string message, T argument);

        void Info(string message);
        void Info(string message, params object[] args);
        void Info(IFormatProvider format, string message, params object[] args);
        void Info<T>(string message, T argument);
        void Info<T>(IFormatProvider formatProvider, T value);
        void Info<T>(IFormatProvider format, string message, T argument);

        void Debug(string message);
        void Debug(string message, params object[] args);
        void Debug(IFormatProvider format, string message, params object[] args);
        void Debug<T>(string message, T argument);
        void Debug<T>(IFormatProvider formatProvider, T value);
        void Debug<T>(IFormatProvider format, string message, T argument);

        void Warn(string message);
        void Warn(string message, params object[] args);
        void Warn(IFormatProvider format, string message, params object[] args);
        void Warn<T>(string message, T argument);
        void Warn<T>(IFormatProvider formatProvider, T value);
        void Warn<T>(IFormatProvider format, string message, T argument);

        void Fatal(string message);
        void Fatal(string message, params object[] args);
        void Fatal(IFormatProvider format, string message, params object[] args);
        void Fatal<T>(string message, T argument);
        void Fatal<T>(IFormatProvider formatProvider, T value);
        void Fatal<T>(IFormatProvider format, string message, T argument);

        void InfoException(string message, Exception exception);
        void DebugException(string message, Exception exception);
        void ErrorException(string message, Exception ex);
        void FatalException(string message, Exception ex);
        void WarnException(string message, Exception ex);

    }
}
