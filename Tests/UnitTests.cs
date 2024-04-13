using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Sub_Valid()
        {
            Assert.AreEqual(5, Program.Subtract("10", "5"));
            Assert.AreEqual(-5, Program.Subtract("5", "10"));
            Assert.AreEqual(21, Program.Subtract("27", "6"));
        }

        [Test]
        public void Pow_Valid()
        {
            Assert.AreEqual(81, Program.Power("9", "2"));
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(32, Program.Power("2", "5"));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(6, Program.Divide("36", "6"));
            Assert.AreEqual(7, Program.Divide("70", "10"));
            Assert.AreEqual(8, Program.Divide("56", "7"));
        }

        
    }
}
