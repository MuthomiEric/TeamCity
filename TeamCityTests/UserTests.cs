using NUnit.Framework;

namespace TeamCityTests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Assert_That_A_String_Equals_Name()
        {
            string name = "Muthomii";

            Assert.AreEqual("Muthomi", name);
        }
    }
}