
from leap_year import LeapYear

def test_normal_leap_year():
    leap_year = LeapYear()
    assert True == leap_year.is_leap(1996)
    
def test_normal_common_year():
    leap_year = LeapYear()
    assert False == leap_year.is_leap(2001)

def test_special_leap_year():
    leap_year = LeapYear()
    assert True == leap_year.is_leap(2000)
    
def test_special_common_year():
    leap_year = LeapYear()
    assert False == leap_year.is_leap(1900)
