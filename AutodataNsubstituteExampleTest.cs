using Xunit;
using NSubstitute;

namespace NsubstitueWithAutodataExample
{
    public class AutodataNSubstituteExampleTest
    {

        [Theory, AutoNSubstitute]
        public void AutoData_create_mocks_for_me(ISomeDependency dependency, ISomeOtherDependency otherDependency, ISomeArg exampleArgs, ILog log)
        {
			var sut = new SystemUnderTest(dependency, otherDependency, log);
			
			sut.MethodToTest(exampleArgs);

			dependency.Received(1).Hello(exampleArgs);
			otherDependency.Received(1).Hello(exampleArgs);
        }
    }
}