using LeapYear;
using NUnit.Framework;

namespace LeapYearTests
{
    [TestFixture]
    public class LeapYearHelperTest
    {
        [Test]
        public void TestingNormalLeapYear()
        {
            Assert.IsTrue(LeapYearHelper.IsLeapYear(1996));
        }

        [Test]
        public void TestingCommonNormalYear()
        {
            Assert.IsFalse(LeapYearHelper.IsLeapYear(2001));
        }
    }
}
