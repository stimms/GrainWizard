using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrainWizard
{
    public class ColorSet : IColorSet
    {
        public string BackgroundColor { get; set; }
        public string TextColor { get; set; }
        public string MainColor { get; set; }
    }
}
