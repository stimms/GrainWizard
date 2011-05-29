using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrainWizard
{
    class ColorSetLibrary
    {
        public static Dictionary<String, ColorSet> ColorSets
        {
            get
            {
                var sets = new Dictionary<String, ColorSet>();
                sets.Add("Barley", new ColorSet
                {//http://www.colourlovers.com/palette/1595028/Firepitt
                    BackgroundColor = "#6F0212",
                    MainColor = "#6E6356",
                    TextColor = "F0DDBA"
                });
                sets.Add("Oat", new ColorSet
                {//http://www.colourlovers.com/palette/1595019/Army_of_colours
                    BackgroundColor = "#F4E500",
                    MainColor = "#D23388",
                    TextColor = "#29B6E3"
                });
                sets.Add("Canola", new ColorSet
                {
                    BackgroundColor = "#F38630",
                    MainColor = "#69D2E7",
                    TextColor = "#F38630"
                });
                return sets;
            }
        }
    }
}
