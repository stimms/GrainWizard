using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrainWizard
{
    public partial class ColorThemePicker : Form
    {
        private IColorSet _selectedColor;

        public IColorSet GetSelectedColorSet()
        {
            return _selectedColor;
        }

        public ColorThemePicker()
        {
            InitializeComponent();
            foreach(var item in ColorSetLibrary.ColorSets.Select(x => x.Key ))
            {
                colorSet.Items.Add(item);
            }
        }

        private void ColorThemePicker_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorSetLibrary.ColorSets.Where(x => x.Key == (string)colorSet.SelectedItem).FirstOrDefault().Value;
            this.Dispose();
        }
    }
}
