
class LeapYear():
    def is_leap(self, year):
        return not self.is_atypical_common_year(year) and self.is_typical_leap_year(year)
    
    def is_typical_leap_year(self, year):
        return year % 4 == 0
        
    def is_atypical_common_year(self, year):
        return year%100 == 0 and not year%400 == 0