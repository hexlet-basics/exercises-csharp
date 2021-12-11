#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsNotLannisterSoldier("blue", null) == true);
PAssert.IsTrue(() => App.IsNotLannisterSoldier("red", null) == false);
PAssert.IsTrue(() => App.IsNotLannisterSoldier("red", "man") == true);
PAssert.IsTrue(() => App.IsNotLannisterSoldier("red", "lion") == false);
PAssert.IsTrue(() => App.IsNotLannisterSoldier("blue", "lion") == false);
