#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.JoinNumbersFromRange(2, 2) == "2");
PAssert.IsTrue(() => App.JoinNumbersFromRange(1, 5) == "12345");
PAssert.IsTrue(() => App.JoinNumbersFromRange(10, 12) == "101112");
