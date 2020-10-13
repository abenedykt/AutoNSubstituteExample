using System;

namespace NsubstitueWithAutodataExample
{
    public class SystemUnderTest
    {
        private readonly ISomeDependency _dependency;
        private readonly ISomeOtherDependency _otherDependency;
        private readonly ILog _log;

        public SystemUnderTest(ISomeDependency dependency, ISomeOtherDependency otherDependency, ILog log)
        {
            _dependency = dependency;
            _otherDependency = otherDependency;
            _log = log;
        }
        public void MethodToTest(ISomeArg argument){
            _dependency.Hello(argument);
            _otherDependency.Hello(argument);
        }
    }
}
