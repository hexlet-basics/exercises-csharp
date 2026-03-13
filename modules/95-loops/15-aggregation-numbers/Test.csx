#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.MultiplyNumbersFromRange(2, 2);
PowerAssert.PAssert.IsTrue(() => actual1 == 2);

var actual2 = App.MultiplyNumbersFromRange(1, 3);
PowerAssert.PAssert.IsTrue(() => actual2 == 6);

var actual3 = App.MultiplyNumbersFromRange(1, 5);
PowerAssert.PAssert.IsTrue(() => actual3 == 120);

var actual4 = App.MultiplyNumbersFromRange(2, 5);
PowerAssert.PAssert.IsTrue(() => actual4 == 120);

var actual5 = App.MultiplyNumbersFromRange(0, 5);
PowerAssert.PAssert.IsTrue(() => actual5 == 0);

var actual6 = App.MultiplyNumbersFromRange(-4, -2);
PowerAssert.PAssert.IsTrue(() => actual6 == -24);

var actual7 = App.MultiplyNumbersFromRange(-4, -3);
PowerAssert.PAssert.IsTrue(() => actual7 == 12);
