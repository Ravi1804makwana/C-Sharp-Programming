using System;

namespace InterfaceDemo
{
    public interface ILogger
    {
        void LogError(String message);
        void LogInfo(String message);
    }
}
