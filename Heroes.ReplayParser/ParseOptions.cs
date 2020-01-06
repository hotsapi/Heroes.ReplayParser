using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.ReplayParser
{
    public class ParseOptions
    {
        public bool IgnoreErrors { get; set; } = false;
        public bool AllowPTR { get; set; } = false;
        public bool ShouldParseEvents { get; set; } = true;
        public bool ShouldParseUnits { get; set; } = true;
        public bool ShouldParseMouseEvents { get; set; } = true;
        public bool ShouldParseDetaileBattleLobby { get; set; } = false;
        public bool ShouldParseMessageEvents { get; set; } = false;

        public static ParseOptions FullParsing => new ParseOptions()
        {
            AllowPTR = true,
            ShouldParseDetaileBattleLobby = true,
            ShouldParseMessageEvents = true
        };

        public static ParseOptions MinimalParsing => new ParseOptions()
        {
            ShouldParseEvents = false,
            ShouldParseUnits = false,
            ShouldParseMouseEvents = false
        };
    }
}
