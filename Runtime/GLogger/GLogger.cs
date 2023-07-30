namespace Guyl.Core.Runtime.GLogger
{
    using UnityEngine;

    public static class GLogger
    {
        public static readonly ILogHandler DefaultLoggerHandler;
        public static Logger _logger = new(new EditorGLogger());
        
        static GLogger()
        {
            DefaultLoggerHandler = Debug.unityLogger.logHandler;
            Debug.unityLogger.logHandler = new EditorGLogger();
        }
        
        public static void LogVerbose(string channel, object message, object sender)
        {
            Debug.Log(message);
        }
        
        public static void LogDebug(string channel, object message, object sender)
        {
            Debug.Log(message);
        }
        
        public static void LogInfo(string channel, object message, object sender)
        {
            Debug.Log(message);
        }
        
        public static void Log(string channel, object message, object sender)
        {
            // Debug.Log(message);
            _logger.Log(message);
        }
        
        public static void LogWarning(string channel, object message, object sender)
        {
            Debug.LogWarning(message);
        }
        
        public static void LogError(string channel, object message, object sender)
        {
            Debug.LogError(message);
        }
        
        public static void LogException(string channel, object message, object sender)
        {
            Debug.LogError(message);
        }
    }
}