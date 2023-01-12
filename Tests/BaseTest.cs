using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
        {
            Driver.Initialize();
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
            }
            Driver.Quit();
        }
    }
}
