using Xunit;
using MyWebApi.Services;
namespace MyWebApi.Tests

{
    public class GreertingServiceTests
    {
        [Fact]
        public void GetGreeting_ValidName_ReturnsMessageWithName()
        {
            var service = new GreetingService();
            string name = "Иван";

            var res = service.GetGreeting(name);

            Assert.Contains("Иван", res);
        }
    }

}
