using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;

namespace GrainWizard
{
    public class GrainWizard : IWizard
    {
        private ColorThemePicker _colorThemePicker;

        private Dictionary<String, ColorSet> _colorThemes;

        public GrainWizard()
        {

        }

        // This method is called before opening any item that 
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects 
                // input for the custom message.
                _colorThemePicker = new ColorThemePicker();
                _colorThemePicker.ShowDialog();

                // Add custom parameters.
                replacementsDictionary.Add("$backgroundcolor$", _colorThemePicker.GetSelectedColorSet().BackgroundColor);
                replacementsDictionary.Add("$textcolor$", _colorThemePicker.GetSelectedColorSet().TextColor);
                replacementsDictionary.Add("$maincolor$", _colorThemePicker.GetSelectedColorSet().MainColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        } 
    }
}
