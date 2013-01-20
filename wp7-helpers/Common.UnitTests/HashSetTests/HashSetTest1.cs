using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.UnitTests.HashSetTests
{
    [TestClass]
    public class HashSetTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var hs = new HashSet<string>();
            Assert.IsTrue(hs.Add("hello"));
        }

        [TestMethod]
        public void TestAddTwice()
        {
            var hs = new HashSet<string>();
            hs.Add("hello");
            Assert.IsFalse(hs.Add("hello"));
        }
    }
}
