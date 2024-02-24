namespace CSMatrix;

public class Worm(int spaceSize, int charSize, char[] fullChars)
{
    public int Y { get; private set; } = 0;
    public int SpaceSize { get; private set; } = spaceSize;
    public int CharSize { get; private set; } = charSize;
    public char[] Chars { get; private set; } = fullChars;
    public int Size => SpaceSize + CharSize;

    public void Move() => Y++;
}
