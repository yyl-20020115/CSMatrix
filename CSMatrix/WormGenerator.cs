namespace CSMatrix;

public class WormGenerator()
{
    private static readonly Random random = new();

    public static Worm Create(int maxSize)
    {
        SetSpaceAndCharSize(maxSize, out int spaceSize, out int charSize);

        var chars = new char[maxSize];
        for (int i = 0; i < maxSize; i++)
            chars[i] = CharUtils.GetRandomChar();
        return new Worm(spaceSize, charSize, chars);
    }

    private static void SetSpaceAndCharSize(int maxSize, out int spaceSize, out int charSize)
    {
        /*// v1
        charSize = random.Next(5, maxSize - 5);
        spaceSize = random.Next(5, maxSize - charSize);*/

        /*// v2
        spaceSize = random.Next(5, maxSize);
        charSize = random.Next(0, maxSize - spaceSize);*/

        /*// v3
        spaceSize = random.Next(15, maxSize + 10);
        charSize = random.Next(5, maxSize);*/

        /*// v4
        spaceSize = random.Next(10, 30);
        charSize = random.Next(5, 20);*/

        /*// v5
        spaceSize = random.Next(20, maxSize + 20);
        charSize = random.Next(5, maxSize - 10);*/

        // v6
        spaceSize = random.Next(15, 20 + maxSize);
        charSize = random.Next(5, 20 + maxSize / 4);
    }
}
