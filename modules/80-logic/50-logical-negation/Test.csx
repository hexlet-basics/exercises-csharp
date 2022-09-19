#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.IsNotLannisterSoldier("blue", null);
PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsNotLannisterSoldier("red", null);
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsNotLannisterSoldier("red", "man");
PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsNotLannisterSoldier("red", "lion");
PAssert.IsTrue(() => actual4 == false);

var actual5 = App.IsNotLannisterSoldier("blue", "lion");
PAssert.IsTrue(() => actual5 == false);
