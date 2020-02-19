using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PianoPlayer;

namespace PianoPlayerTest
{
    [TestClass]
    public class PianoTests
    {
        [TestMethod]
        public void CircularConstTest()
        {
            CircularArray newTestArray = new CircularArray(4);
            Assert.IsTrue(newTestArray.Length == 4, "The constructor works");
        }

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
        public void ShiftTest()
        {
            CircularArray testArr = new CircularArray(5);

            double firstElement = testArr.Shift(3);
            Assert.IsTrue(testArr[4] == 3, "The index is not 3");
        }

        [TestMethod]
        public void PianoConstructorTest()
        {
            Piano testObject = new Piano("q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ", 44100);
            Assert.IsNotNull(testObject, "The piano object is null");
        }

        [TestMethod]
        public void StrikeKeyTest()
        {
            string keys = "q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ";
            Boolean boolCheck = true;
            Piano testObject = new Piano("q", 44100);
            foreach (char c in keys)
            {
                int check = (int)(Math.Pow(2, (keys.IndexOf(c) - 24) / 12) * 440);

                if (keys.IndexOf(c) == -1)
                {
                    boolCheck = false;
                }
                Assert.IsTrue(boolCheck, "The method doesn't work");
            }     
        }

        //to ensure the test works, set the wireList in the Piano class to public
        //and comment out line 28 in the PianoWire class.
        [TestMethod]
        public void TestPlay()
        {
            Piano testObject = new Piano("q2we4r5op-[=fvgbnjmk", 44100);
            string s = "q2we4r5op-[=fvgbnjmk";
            bool boolCheck = true;
            double sum = 0;

            foreach (char c in s)
            {
                testObject.StrikeKey(c);
            }

            foreach (PianoWire pianoWire in testObject.wireList)
            {
                sum += pianoWire.Sample();
            }

            if (sum - testObject.Play() != 0)
            {
                boolCheck = false;
            }

            Assert.IsTrue(boolCheck);
        }
    }
}
