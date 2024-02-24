namespace CSMatrix;

public class ColumnNewStyle
{
    public int X;
    public int fullSize;
    private readonly List<Worm> worms;
    private readonly char[] chars;

    public ColumnNewStyle(int XPos, int size)
    {
        X = XPos;
        chars = new char[fullSize = size];
        worms =
        [
            WormGenerator.Create(fullSize)
        ]; 

        for (int i = 0; i < size; i++)
            chars[i] = ' ';
    }

    //int counter = 0;
    public void Scroll()
    {
        foreach (var worm in worms)
            worm.Move();

        var lastWorm = worms.Last();
        if (lastWorm.Y >= lastWorm.Size)
            worms.Add(WormGenerator.Create(fullSize));

        var firstWorm = worms.First();
        if (firstWorm.Y >= firstWorm.Size + fullSize)
            worms.Remove(firstWorm);

        RefreshChars();
    }

    private void RefreshChars()
    {
        foreach (var worm in worms)
            // TODO: improve this :/
            for (var i = 0; i < worm.Size; i++)
                if (worm.Y - i <= 0) 
                    continue;
                else if (worm.Y - i > 0 && worm.Y - i < fullSize)
                    chars[worm.Y - i] = i < worm.SpaceSize 
                        ? ' ' : worm.Chars[worm.Y - i];
    }

    public char GetChar(int YPos) 
        => chars[YPos];
}
