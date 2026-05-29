#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsMister("8234782");
PowerAssert.PAssert.IsTrue(() => actual1 == false);

var actual2 = App.IsMister("Joker");
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsMister("Mister");
PowerAssert.PAssert.IsTrue(() => actual3 == true);
