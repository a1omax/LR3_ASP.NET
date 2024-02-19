namespace ASP.NET.services
{
    public class DayTimeAnalyzerService : interfaces.IDayTimeAnalyzer
    {
        public string GetTimeInHumanForm(DateTime dateTime)
        {
            // ukr locale not arbeite
            int hour = dateTime.Hour;
            if (0 <= hour && hour < 6) 
            {
                return "It's night right now";
            }
            if (6 <= hour && hour < 12)
            {
                return "It's morning right now";
            }
            if (12 <= hour && hour < 18)
            {
                return "It's day right now";
            }
            if (18 <= hour && hour < 24)
            {
                return "It's evening right now";
            }
            throw new Exception("Invalid data");
        }

    }
}
