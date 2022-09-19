#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.Encrypt("move");
PAssert.IsTrue(() => actual1 == "omev");

var actual2 = App.Encrypt("attack");
PAssert.IsTrue(() => actual2 == "taatkc");

var actual3 = App.Encrypt("go!");
PAssert.IsTrue(() => actual3 == "og!");
