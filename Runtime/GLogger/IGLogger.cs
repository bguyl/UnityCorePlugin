namespace Guyl.Core.Runtime.GLogger
{
    public interface IGLogger
    {
        public void LogVerbose(string channel, object message, object sender);
        
        public void LogDebug(string channel, object message, object sender);
        
        public void LogInfo(string channel, object message, object sender);
        
        public void Log(string channel, object message, object sender);
        
        public void LogWarning(string channel, object message, object sender);
        
        public void LogError(string channel, object message, object sender);
        
        public void LogException(string channel, object message, object sender);
    }
}