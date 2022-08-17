
using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisobj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1",CultureInfo.InvariantCulture);
            }
            else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + "Hours";
            }


        }


    }
}
