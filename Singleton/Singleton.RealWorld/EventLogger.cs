namespace Singleton.RealWorld
{
    using System.Collections.Generic;

    public class EventLogger
    {
        private static EventLogger instance;
        private List<string> eventLogs;

        private EventLogger()
        {
            this.eventLogs = new List<string>();
        }

        public static EventLogger GetInstance()
        {
            instance ??= new EventLogger();

            return instance;
        }


        public void LogEvent(string eventMessage)
        {
            string timeStamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            this.eventLogs.Add($"{timeStamp}: {eventMessage}");
        }

        public void DisplayLogs()
        {
            foreach (string log in this.eventLogs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
