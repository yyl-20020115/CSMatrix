using CommandLine;

namespace CSMatrix
{
    public class Options : BaseAttribute
    {
        [Option('o', HelpText = "Use old-style scrolling")]
        public bool OldStyle { get; set; } = false;

        [Option('u', Default = 4, HelpText = "Screen update delay (0 - 10)")]
        public int Delay { get; set; } = 0;

        [Option('C', Default = "green", HelpText = "Use this color for matrix")]
        public string Color { get; set; } = "";

    }
}
