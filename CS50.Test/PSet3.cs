using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS50.Test
{
    [TestClass]
    public class PSet3
    {
        [TestMethod]
        public void CanFindLowestValue()
        {
            var values = new[] { 4, 3, 1, 2 };
            var lowest = CSharp.PSet3Custom.LowestValue(values, 0, values.Length);
            Assert.IsTrue(lowest[0] == 1);
        }

        [TestMethod]
        public void CanShift()
        {
            var values = new[] { 4, 3, 2, 1 };
            CSharp.PSet3Custom.Shift(values, 0, values.Length - 1);
            Assert.IsTrue(values[0] == 4 && values[1] == 4 && values[2] == 3 && values[3] == 2);
        }

        [TestMethod]
        public void CanShiftUnOrdered()
        {
            var values = new[] { 4, 3, 1, 5, 9, 78, 7 };
            CSharp.PSet3Custom.Shift(values, 0, 2);
            CollectionAssert.AreEqual(values, new[] { 4, 4, 3, 5, 9, 78, 7 });
        }

        [TestMethod]
        public void CanSort()
        {
            var values = new[] { 4, 3, 1, 5, 9, 78, 7 };
            var sortedList = new[] { 1, 3, 4, 5, 7, 9, 78 };
            CSharp.PSet3Custom.Sort(values, values.Length);
            CollectionAssert.AreEqual(values, sortedList);
        }
    }
}