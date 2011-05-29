using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrainWizard
{
    public interface IColorSet
    {
        string BackgroundColor { get; set; }
        string TextColor { get; set; }
        string MainColor { get; set; }
    }
}
