namespace CSMatrix;

public static class CharUtils
{
    private static readonly Random random = new();

    public static char GetRandomChar() 
        => (char)(Next(100) switch {
        < 25 => Next(33, 127),
        _ => Next(100) switch {
            < 33 => Next(48, 58),
            < 66 => Next(65, 91),
            _ => Next(97, 123)
        }
    });

    public static int Next(int limit)
        => random.Next(limit);

    public static int Next(int minValue, int maxValue) 
        => random.Next(minValue, maxValue);
}
