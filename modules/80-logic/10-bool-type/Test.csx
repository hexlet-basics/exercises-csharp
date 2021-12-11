#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsPensioner(70) == true);
PAssert.IsTrue(() => App.IsPensioner(50) == false);
PAssert.IsTrue(() => App.IsPensioner(60) == true);
PAssert.IsTrue(() => App.IsPensioner(59) == false);
