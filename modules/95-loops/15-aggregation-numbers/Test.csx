#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.MultiplyNumbersFromRange(2, 2) == 2);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(1, 3) == 6);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(1, 5) == 120);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(2, 5) == 120);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(0, 5) == 0);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(-4, -2) == -24);
PAssert.IsTrue(() => App.MultiplyNumbersFromRange(-4, -3) == 12);
