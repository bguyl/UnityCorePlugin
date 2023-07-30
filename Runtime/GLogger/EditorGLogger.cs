using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Guyl.Core.Runtime.GLogger
{
    public class EditorGLogger : ILogger, IGLogger
    {
        
        
        public EditorGLogger()
        {
            ILogger defaultLogger = Debug.unityLogger;
        }

        public void LogFormat(LogType logType, Object context, string format, params object[] args)
        {
            GLogger.DefaultLoggerHandler.LogFormat(logType, context, "Nope", args);
            // GLogger.DefaultLogger.LogFormat(logType, "Nope");
            // GLogger.DefaultLogger.LogFormat(logType, context, format, args);
            // Console.WriteLine("Foobar");
        }

        public void LogException(Exception exception, Object context)
        {
            // Console.WriteLine("Foobar");
        }

        public bool IsLogTypeAllowed(LogType logType)
        {
            return true;
        }

        public void Log(LogType logType, object message)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(LogType logType, object message, Object context)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(LogType logType, string tag, object message)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(LogType logType, string tag, object message, Object context)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(object message)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(string tag, object message)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void Log(string tag, object message, Object context)
        {
            // GLogger.DefaultLogger.Log("Foobar");
            // Console.WriteLine("Foobar");
        }

        public void LogWarning(string tag, object message)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogWarning(string tag, object message, Object context)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogError(string tag, object message)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogError(string tag, object message, Object context)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogFormat(LogType logType, string format, params object[] args)
        {
            GLogger.DefaultLoggerHandler.LogFormat(logType, null, format, args);
            // Console.WriteLine("Foobar");
        }

        public void LogException(Exception exception)
        {
            // Console.WriteLine("Foobar");
        }

        public ILogHandler logHandler { get; set; }
        public bool logEnabled { get; set; } = true;
        public LogType filterLogType { get; set; }
        public void LogVerbose(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogDebug(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogInfo(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void Log(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogWarning(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogError(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }

        public void LogException(string channel, object message, object sender)
        {
            // Console.WriteLine("Foobar");
        }
    }
}