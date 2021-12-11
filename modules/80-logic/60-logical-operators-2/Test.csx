#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsNeutralSoldier("yellow", "black") == true);
PAssert.IsTrue(() => App.IsNeutralSoldier("red", "black") == false);
PAssert.IsTrue(() => App.IsNeutralSoldier("red", "red") == false);
