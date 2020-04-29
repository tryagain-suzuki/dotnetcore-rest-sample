using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiSample.UnitTest
{
    [TestClass]
    public class ServicesUnitTest
    {
        [TestMethod]
        public void CreateGreeting_NomalCase()
        {
            var service = new Services.GreetingService();
            string name = "Suzuki";

            var greeting = service.CreateGreeting(name);

            Assert.AreEqual($@"Hello, {name}!!", greeting);
        }
    }
}
