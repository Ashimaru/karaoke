using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingItBetterBackend;
namespace BackendTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnValidValue_whengetStringInvoked()
        {
            var c1 = new Class1();
            Assert.AreEqual(c1.getString(), "Test");
        }
    }
}
