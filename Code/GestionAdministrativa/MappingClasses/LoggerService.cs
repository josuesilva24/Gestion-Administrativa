using System.Diagnostics;

namespace MappingClasses
{
    public static class LoggerService
    {
        private const string Source = "GestionAdministrativa";
        public static void WriteEntryError(string logMessage)
        {
            if (!EventLog.SourceExists(Source))
                EventLog.CreateEventSource(Source, Source);

            EventLog.WriteEntry(Source, logMessage, EventLogEntryType.Error);
        }
        public static void WriteEntryInformation(string logMessage)
        {
            if (!EventLog.SourceExists(Source))
                EventLog.CreateEventSource(Source, Source);

            EventLog.WriteEntry(Source, logMessage, EventLogEntryType.Information);
        }

    }
}
