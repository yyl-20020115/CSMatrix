namespace CSMatrix;

public class ColumnOldStyle
{
    private static readonly Random random = new();
    private bool isCurrentWhite = true;
    public int length = RandomSpaceSize;

    public ColumnOldStyle() { }
    private static int RandomSpaceSize =>
        //return random.Next(max * 20 / 100, max * 90 / 100);
        random.Next(10, 50);

    private static int RandomCharSize =>
        //return random.Next(max * 20 / 100, max * 90 / 100);
        random.Next(10, 20);

    public char GetNextChar()
    {
        length--;
        if (length == -1)
        {
            isCurrentWhite = !isCurrentWhite;
            length = isCurrentWhite ? RandomSpaceSize : RandomCharSize;
        }
        return isCurrentWhite ? ' ' : CharUtils.GetRandomChar();
    }
}
