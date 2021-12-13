#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.Encrypt("move") == "omev");
PAssert.IsTrue(() => App.Encrypt("attack") == "taatkc");
PAssert.IsTrue(() => App.Encrypt("go!") == "og!");
