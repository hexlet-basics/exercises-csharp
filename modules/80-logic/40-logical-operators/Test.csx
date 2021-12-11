#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsLannisterSoldier("blue", null) == false);
PAssert.IsTrue(() => App.IsLannisterSoldier("red", "man") == false);
PAssert.IsTrue(() => App.IsLannisterSoldier("red", "lion") == true);
PAssert.IsTrue(() => App.IsLannisterSoldier("blue", "lion") == true);
PAssert.IsTrue(() => App.IsLannisterSoldier("red", null) == true);
