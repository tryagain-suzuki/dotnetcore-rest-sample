using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiSample.UnitTest
{
    [TestClass]
    public class ServicesUnitTest
    {
        [TestMethod]
        public void CreateGreeting_NormalCase()
        {
            var service = new Services.GreetingService();
            string name = "TryAgainSuzuki";
            string expected = $@"Hello, {name}!!";

            var actual = service.CreateGreeting(name);

            Assert.AreEqual(expected, actual);
        }
    }
}
