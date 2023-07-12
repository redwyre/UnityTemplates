
using Verify = Microsoft.CodeAnalysis.CSharp.Testing.MSTest.CodeRefactoringVerifier<CodeRefactorings.UnityCodeRefactoringProvider>;
using Microsoft.CodeAnalysis.Testing;

namespace CodeRefactorings.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            string testCode =
@"
interface IComponentData
{
}

struct Component : IComponentData
{
}";
            string fixedCode =
@"
interface IComponentData
{
}

struct Component : IComponentData
{
}";
            var expected = new DiagnosticResult().WithLocation(5, 8);
            await Verify.VerifyRefactoringAsync(testCode, expected, fixedCode);
        }
    }
}