#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.Encrypt("move");
PowerAssert.PAssert.IsTrue(() => actual1 == "omev");

var actual2 = App.Encrypt("attack");
PowerAssert.PAssert.IsTrue(() => actual2 == "taatkc");

var actual3 = App.Encrypt("go!");
PowerAssert.PAssert.IsTrue(() => actual3 == "og!");
