﻿using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Rewards.API.Logging
{


    public class FileLogger : ILogger
    {
        protected readonly  FileLoggerProvider _loggerFileProvider;

        public FileLogger([NotNull]  FileLoggerProvider  loggerFileProvider)
        {
            _loggerFileProvider = loggerFileProvider;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var fullFilePath = _loggerFileProvider.Options.FolderPath + "/" + _loggerFileProvider.Options.FilePath.Replace("{date}", DateTimeOffset.UtcNow.ToString("yyyyMMdd"));
            var logRecord = string.Format("{0} [{1}] {2} {3}", "[" + DateTimeOffset.UtcNow.ToString("yyyy-MM-dd HH:mm:ss+00:00") + "]", logLevel.ToString(), formatter(state, exception), exception != null ? exception.StackTrace : "");

            using (var streamWriter = new StreamWriter(fullFilePath, true))
            {
                streamWriter.WriteLine(logRecord);
            }
        }
    }
}
