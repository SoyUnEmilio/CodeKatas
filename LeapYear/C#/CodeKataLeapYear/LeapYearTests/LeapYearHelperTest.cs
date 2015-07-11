using LeapYear;
using NUnit.Framework;

namespace LeapYearTests
{
    [TestFixture]
    public class LeapYearHelperTest
    {
        [Test]
        public void IsLeapYear_TestingNormalLeapYear1996_ShouldBeTrue()
        {
            Assert.IsTrue(LeapYearHelper.IsLeapYear(1996));
        }

        [Test]
        public void IsLeapYear_TestingNormalCommonYear2001_ShouldBeFalse()
        {
            Assert.IsFalse(LeapYearHelper.IsLeapYear(2001));
        }

        [Test]
        public void IsLeapYear_TestingSpecialLeapY
    }
}
