using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingItBetter.UI.ViewModel;

namespace SingItBetter.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnValidValue_whenGetStringInvoked()
        {
            var c1 = new Class1();
            Assert.AreEqual(c1.GetString(), "Test");
        }
    }
}