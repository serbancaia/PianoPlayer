using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PianoTests
{
    [TestClass]
    public class PianoUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void PianoWireConstructorTest()
        {
            PianoWire pianoWire = new PianoWire(6, 2);
            Assert.AreEqual(3, pianoWire.circularArray.Length, "Expected result of 3 but value was different");
        }
        [TestMethod]
        public void PianoWireSampleTest()
        {

        }
    }
}
