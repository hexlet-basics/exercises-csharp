#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.IsNeutralSoldier("yellow", "black");
PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsNeutralSoldier("red", "black");
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsNeutralSoldier("red", "red");
PAssert.IsTrue(() => actual3 == false);
