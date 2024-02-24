namespace CSMatrix;

public static class ScrollColors
{
    public static readonly KeyValuePair<string, ConsoleColor> Default
        = new("green", ConsoleColor.DarkGreen);

    private static readonly Dictionary<string, ConsoleColor> colors = new()
    {
        {Default.Key,Default.Value},
        {"blue",ConsoleColor.DarkBlue},
        {"white",ConsoleColor.White},
        {"red",ConsoleColor.DarkRed}
    };

    public static ConsoleColor Parse(string colorStr)
        => colors.ContainsKey(colorStr.ToLower()) ? colors[colorStr.ToLower()] : Default.Value;

}
