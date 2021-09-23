using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueSums.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ShouldEqual22()
        {
            var list = new List<List<int>>
            {
                new() {1, 2, 3},    // unique (6)
                new() {1, 2, 3},    // not unique
                new() {4, 3, 2},    // unique (9)
                new() {4, 3, 2},    // not unique
                new() {4, 3, 2},    // not unique
                new() {1, 1, 1},    // unique (3)
                new() {4, 3, 2},    // not unique
                new() {1, 2, 3},    // not unique
                new() {1, 1, 1},    // not unique
                new() {1, 1, 1, 1}, // unique (4)
                new() {1, 1, 1}     // not unique

                // should equal 22
            };

            var sum = Program.GetUniqueSubListSum(list);
            Assert.AreEqual(22, sum);
        }

        [TestMethod]
        public void ShouldEqual18()
        {
            var list = new List<List<int>>
            {
                new() {1, -2, 3},    // unique (2)
                new() {1, -2, 3},    // not unique
                new() {4, 3, 2},    // unique (9)
                new() {4, 3, 2},    // not unique
                new() {4, 3, 2},    // not unique
                new() {1, 1, 1},    // unique (3)
                new() {4, 3, 2},    // not unique
                new() {1, -2, 3},    // not unique
                new() {1, 1, 1},    // not unique
                new() {1, 1, 1, 1}, // unique (4)
                new() {1, 1, 1}     // not unique

                // should equal 18
            };

            var sum = Program.GetUniqueSubListSum(list);
            Assert.AreEqual(18, sum);
        }
    }
}
