#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.IsLannisterSoldier("blue", null);
PAssert.IsTrue(() => actual1 == false);

var actual2 = App.IsLannisterSoldier("red", "man");
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsLannisterSoldier("red", "lion");
PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsLannisterSoldier("blue", "lion");
PAssert.IsTrue(() => actual4 == true);

var actual5 = App.IsLannisterSoldier("red", null);
PAssert.IsTrue(() => actual5 == true);
