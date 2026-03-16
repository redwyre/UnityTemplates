using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace UnityTemplates
{
    public sealed class TemplateOptionsWizard : IWizard
    {
        public const string UseUnityNamespaceParameterName = "$useunitynamespace$";
        public const string UnityNamespaceParameterName = "$unitynamespace$";

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            GeneralOptionsPage optionsPage = LoadOptions();

            bool useNamespace = optionsPage.UseNamespace != NamespaceOption.None;

            string ns = optionsPage.useNamespace switch
            {
                NamespaceOption.None => string.Empty,
                NamespaceOption.Default => replacementsDictionary["$defaultnamespace$"],
                NamespaceOption.RootNamespace => replacementsDictionary["$rootnamespace$"],
                NamespaceOption.Custom => optionsPage.CustomNamespace,
                _ => throw new ArgumentOutOfRangeException()
            };

            replacementsDictionary[UseUnityNamespaceParameterName] = useNamespace.ToString();
            replacementsDictionary[UnityNamespaceParameterName] = ns;
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        private static GeneralOptionsPage LoadOptions()
        {
            GeneralOptionsPage optionsPage = new GeneralOptionsPage();
            optionsPage.LoadSettingsFromStorage();
            return optionsPage;
        }
    }
}
