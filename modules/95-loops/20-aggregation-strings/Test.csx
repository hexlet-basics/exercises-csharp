#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.JoinNumbersFromRange(2, 2);
PowerAssert.PAssert.IsTrue(() => actual1 == "2");

var actual2 = App.JoinNumbersFromRange(1, 5);
PowerAssert.PAssert.IsTrue(() => actual2 == "12345");

var actual3 = App.JoinNumbersFromRange(10, 12);
PowerAssert.PAssert.IsTrue(() => actual3 == "101112");
