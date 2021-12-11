#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsLeapYear(2018) == false);
PAssert.IsTrue(() => App.IsLeapYear(2017) == false);
PAssert.IsTrue(() => App.IsLeapYear(2016) == true);
PAssert.IsTrue(() => App.IsLeapYear(2000) == true);
PAssert.IsTrue(() => App.IsLeapYear(1900) == false);
