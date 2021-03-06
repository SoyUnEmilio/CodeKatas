﻿using LeapYear;
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
        public void IsLeapYear_TestingSpecialLeapYear2000_ShouldBeTrue()
        {
            Assert.IsTrue(LeapYearHelper.IsLeapYear(2000));
        }

        [Test]
        public void IsLeapYear_TestingSpecialCommonYear1900_ShouldBeFalse()
        {
            Assert.IsFalse(LeapYearHelper.IsLeapYear(1900));
        }
    }
}
