using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingItBetterBackend;
namespace BackendTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnTest_whengetStringCalled()
        {
            Class1 c1 = new Class1();
            Assert.AreEqual(c1.getString(), "Test");
        }
    }
}
