﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PianoPlayer;

namespace PianoPlayerTest
{
    [TestClass]
    public class PianoTests
    {
        /// <summary>
        /// This method tests the CircularArray constructor.
        /// </summary>
        [TestMethod]
        public void CircularConstTest()
        {
            Assert.IsTrue(new CircularArray(3).Length == 3, "The constructor works" );
        }

        /// <summary>
        /// This method tests the Fill method in the CircularArray class.
        /// </summary>
        [TestMethod]
        public void FillTest()
        {
            CircularArray testArr = new CircularArray(5);
            double[] array = { 1, 2, 3, 4, 5 };
            testArr.Fill(array);
            CollectionAssert.AreEqual(array, testArr.GetBuffer());
            Assert.IsTrue(testArr[4] == 5, "The index is not 5");
        }
        [TestMethod]
        public void PianoWireGetFrequencyTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);
            Assert.AreEqual(2, pianoWire.getFrequency(), "Expected result of 2 but value was different");
        }
        [TestMethod]
        public void PianoWireGetSamplingRateTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);
            Assert.AreEqual(6, pianoWire.getSamplingRate(), "Expected result of 6 but value was different");
        }
        [TestMethod]
        public void PianoWireGetCircularArrayTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);
            Assert.AreNotEqual(null, pianoWire.getCircularArray(), "Expecting not null value but value was different");
        }
        [TestMethod]
        public void PianoWireConstructorTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);

            Assert.AreEqual(3, pianoWire.getCircularArray().Length, "Expected result of 3 but value was different");
        }
        [TestMethod]
        public void PianoWireStrikeTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);
            pianoWire.Strike();
            Assert.AreNotEqual(null, pianoWire.getCircularArray()[0], "Expecting not null value but value was different");
        }
        [TestMethod]
        public void PianoWireSampleTest()
        {
            PianoWire pianoWire = new PianoWire(2, 6);
            double[] buffer = { 0.2, 0.3, 0.1 };
            pianoWire.getCircularArray().Fill(buffer);
            Assert.AreEqual(buffer[0], pianoWire.Sample(0.996), "Expecting result of 0.2 but value was different");
            Assert.AreEqual(0.249, pianoWire.getCircularArray()[2], "Expecting result of 0.249 but value was different");
        }
    }
}
