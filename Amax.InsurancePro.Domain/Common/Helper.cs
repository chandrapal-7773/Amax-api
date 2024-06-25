namespace Amax.InsurancePro.Domain.Common;

public class Helper
{
    public static DateTime LocalTime(DateTime serverDateTime)
    {
        TimeSpan tsZoneTimeOffset = default(TimeSpan);

        // Determine what our local timezone offset should be in relation to the server's timezone (CST)
        switch (TimeZone.CurrentTimeZone.StandardName)
        {
            case "Pacific Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-2);
                break;
            case "Mountain Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-1);
                break;
            case "Central Standard Time":
                tsZoneTimeOffset = TimeSpan.Zero;
                break;
            case "Eastern Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(1);
                break;
            case "US Eastern Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(1);
                break;
            case "US Mountain Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-1);
                break;
            case "Pacific Standard Time (Mexico)":
                tsZoneTimeOffset = TimeSpan.FromHours(-2);
                break;
            case "Alaskan Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-3);
                break;
            case "Hawaiian Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-4);
                break;
            case "UTC-11":
                tsZoneTimeOffset = TimeSpan.FromHours(-5);
                break;
            case "Dateline Standard Time":
                tsZoneTimeOffset = TimeSpan.FromHours(-6);
                break;
            default:
                tsZoneTimeOffset = TimeSpan.Zero;
                break;
        }

        TimeSpan actualTimeOffset = DateTime.Now - (serverDateTime + tsZoneTimeOffset);

        // Calculate the correct local time based on the actual time offset..
        DateTime dtCurrentLocalTime = DateTime.Now;
        if (actualTimeOffset > TimeSpan.Zero)
            dtCurrentLocalTime -= actualTimeOffset;
        else
            dtCurrentLocalTime += actualTimeOffset.Negate();

        try
        {
            // Take into account Daylight Savings Time.. This can be off by one hour in some ambiguous situations..
            if (!dtCurrentLocalTime.IsDaylightSavingTime())
                dtCurrentLocalTime.AddHours(-1);
        }
        catch
        {
            dtCurrentLocalTime = DateTime.Now;
        }

        return dtCurrentLocalTime;
    }

}