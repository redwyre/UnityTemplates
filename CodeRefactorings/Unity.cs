using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CodeRefactorings
{
    public static class Unity
    {
        public static readonly BaseTypeSyntax IAspect = BaseType("IAspect");
        public static readonly BaseTypeSyntax IBufferElementData = BaseType("IBufferElementData");
        public static readonly BaseTypeSyntax IComponentData = BaseType("IComponentData");
        public static readonly BaseTypeSyntax ISystem = BaseType("ISystem");
        public static readonly BaseTypeSyntax MonoBehaviour = BaseType("MonoBehaviour");
        public static readonly BaseTypeSyntax ScriptableObject = BaseType("ScriptableObject");
        public static readonly BaseTypeSyntax SystemBase = BaseType("SystemBase");

        public static BaseTypeSyntax BaseType(string name) => SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName(name));
    }
}