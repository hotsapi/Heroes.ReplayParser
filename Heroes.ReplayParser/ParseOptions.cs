using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.ReplayParser
{
    /// <summary>
    /// Parse options, represented as a class.
    /// 
    /// Default options are automatically set, typical use would
    /// be to either use one of the provided static option sets,
    /// or to set your own option set in the initializer
    /// 
    /// i.e. new ParseOption() {
    /// ShouldParseUnits = true
    /// }
    /// </summary>
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
        
        public static ParseOptions MediumParsing => new ParseOptions()
        {
            ShouldParseEvents = false,
            ShouldParseUnits = false,
            ShouldParseMouseEvents = false,
            ShouldParseDetaileBattleLobby = true
        };

        public static ParseOptions MinimalParsing => new ParseOptions()
        {
            ShouldParseEvents = false,
            ShouldParseUnits = false,
            ShouldParseMouseEvents = false
        };

        public static ParseOptions TypicalParsing => new ParseOptions();

    }
}
