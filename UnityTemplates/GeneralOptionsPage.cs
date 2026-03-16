using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace UnityTemplates
{
    public enum NamespaceOption
    {
        None,
        Default,
        RootNamespace,
        Custom
    }

    public class GeneralOptionsPage : DialogPage
    {
        [Category("General")]
        [DisplayName("Namespace option")]
        [Description("Whether to use a namespace in the generated files and what to use.")]
        public NamespaceOption UseNamespace { get; set; } = NamespaceOption.None;

        [Category("General")]
        [DisplayName("Default Namespace")]
        [Description("Custom namespace to use in new Unity scripts.")]
        [DefaultValue("Custom")]
        public string CustomNamespace { get; set; } = "Custom";
    }
}
