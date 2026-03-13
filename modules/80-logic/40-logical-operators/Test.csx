#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsLannisterSoldier("blue", null);
PowerAssert.PAssert.IsTrue(() => actual1 == false);

var actual2 = App.IsLannisterSoldier("red", "man");
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsLannisterSoldier("red", "lion");
PowerAssert.PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsLannisterSoldier("blue", "lion");
PowerAssert.PAssert.IsTrue(() => actual4 == true);

var actual5 = App.IsLannisterSoldier("red", null);
PowerAssert.PAssert.IsTrue(() => actual5 == true);
