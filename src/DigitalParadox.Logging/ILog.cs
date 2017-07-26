using System;

namespace DigitalParadox.Logging
{
    public interface ILog
    {
        void WriteWarning(string message);
        void WriteVerbose(string message);
        void WriteInformation(string message);
        void WriteDebug(string message);
        void WriteError(string message, Exception ex = null);
        void WriteFatal(string message, Exception ex = null);
    }
}
