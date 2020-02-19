using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PianoTests
{
    [TestClass]
    public class PianoUnitTests
    {
        /// <summary>
        /// This method tests the CircularArray constructor.
        /// </summary>
        [TestMethod]
        public void CircularConstTest()
        {
            //Assert.IsTrue(CircularArray(3).Length == 3, "The constructor works" );
        }

        /// <summary>
        /// This method tests the Fill method in the CircularArray class.
        /// </summary>
        public void FillTest()
        {
            CircularArray testArr = new CircularArray(5);
            double[] array = {1,2,3,4,5};
            testArr.Fill(array);
            CollectionAssert.AreEqual(array, testArr.GetBuffer());
            Assert.IsTrue();
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
