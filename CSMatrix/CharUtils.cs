namespace CSMatrix;

public static class CharUtils
{
    private static readonly Random random = new();

    public static char GetRandomChar() 
        => random.Next(100) switch
    {
        < 25 => (char)random.Next(33, 127),
        _ => random.Next(100) switch
        {
            < 33 => (char)random.Next(48, 58),
            < 66 => (char)random.Next(65, 91),
            _ => (char)random.Next(97, 123)
        }
    };

    public static int Next(int minValue, int maxValue) 
        => random.Next(minValue, maxValue);
}
