using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace QuickApp_QA
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("BoMayThichFail")]
    [AllureDisplayIgnored]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test(Description = "This Shall Pas")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]   
        public void ThisShallPass()
        {
            Assert.Pass("Ez gameeee!!!!");
        }       
    }
}