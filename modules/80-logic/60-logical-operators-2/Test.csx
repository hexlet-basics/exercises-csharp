#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsNeutralSoldier("yellow", "black");
PowerAssert.PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsNeutralSoldier("red", "black");
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsNeutralSoldier("red", "red");
PowerAssert.PAssert.IsTrue(() => actual3 == false);
