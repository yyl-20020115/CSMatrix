namespace CSMatrix;

public class ColumnOldStyle
{
    private static readonly Random random = new();
    private bool isCurrentWhite;
    public int length;

    public ColumnOldStyle()
    {
        isCurrentWhite = true;
        length = GetRandomSpaceSize();
    }
    private static int GetRandomSpaceSize() =>
        //return random.Next(max * 20 / 100, max * 90 / 100);
        random.Next(10, 50);

    private int RandomCharSize =>
        //return random.Next(max * 20 / 100, max * 90 / 100);
        random.Next(10, 20);

    public char GetNextChar()
    {
        length--;
        if (length == -1)
        {
            isCurrentWhite = !isCurrentWhite;
            length = isCurrentWhite ? GetRandomSpaceSize() : RandomCharSize;
        }
        return isCurrentWhite ? ' ' : CharUtils.GetRandomChar();
    }
}
