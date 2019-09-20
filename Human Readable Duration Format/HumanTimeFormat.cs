using System;
using System.Collections.Generic;
using System.Linq;

public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        if (seconds < 0)
        {
            throw new ArgumentException();
        }

        if (seconds == 0)
        {
            return "now";
        }

        var components = new List<string>();

        var years = seconds / 31536000;
        seconds %= 31536000;
        if (years > 0)
        {
            components.Add(Format("year", years));
        }

        var days = seconds / 86400;
        seconds %= 86400;
        if (days > 0)
        {
            components.Add(Format("day", days));
        }

        var hours = seconds / 3600;
        seconds %= 3600;
        if (hours > 0)
        {
            components.Add(Format("hour", hours));
        }

        var minutes = seconds / 60;
        seconds %= 60;
        if (minutes > 0)
        {
            components.Add(Format("minute", minutes));
        }

        if (seconds > 0)
        {
            components.Add(Format("second", seconds));
        }

        var result = string.Join(", ", components.Take(components.Count - 1))
            + (components.Count <= 1 ? string.Empty : " and ")
            + components.LastOrDefault();

        return result;

        string Format(string timeBase, int count)
        {
            if (count > 1)
            {
                timeBase += "s";
            }

            return $"{count} {timeBase}";
        }
    }
}