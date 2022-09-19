#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.IsMister("8234782");
PAssert.IsTrue(() => actual1 == false);

var actual2 = App.IsMister("Joker");
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsMister("Mister");
PAssert.IsTrue(() => actual3 == true);
