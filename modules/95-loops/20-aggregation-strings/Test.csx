#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.JoinNumbersFromRange(2, 2);
PAssert.IsTrue(() => actual1 == "2");

var actual2 = App.JoinNumbersFromRange(1, 5);
PAssert.IsTrue(() => actual2 == "12345");

var actual3 = App.JoinNumbersFromRange(10, 12);
PAssert.IsTrue(() => actual3 == "101112");
