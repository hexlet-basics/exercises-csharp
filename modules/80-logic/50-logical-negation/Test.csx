#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsNotLannisterSoldier("blue", null);
PowerAssert.PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsNotLannisterSoldier("red", null);
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsNotLannisterSoldier("red", "man");
PowerAssert.PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsNotLannisterSoldier("red", "lion");
PowerAssert.PAssert.IsTrue(() => actual4 == false);

var actual5 = App.IsNotLannisterSoldier("blue", "lion");
PowerAssert.PAssert.IsTrue(() => actual5 == false);
