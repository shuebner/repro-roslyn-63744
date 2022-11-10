using System.Text.RegularExpressions;

namespace SyntaxHighlightingRepro
{
    public class Repro63744
    {
        public static void Do()
        {
            Regex.Match("foo", @".*Setups\.Minimal\.(?<FileName>.*)");
            new Regex("(.+)");
            new Regex("(.*)");
        }
    }
}
