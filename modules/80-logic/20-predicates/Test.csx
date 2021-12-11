#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsMister("8234782") == false);
PAssert.IsTrue(() => App.IsMister("Joker") == false);
PAssert.IsTrue(() => App.IsMister("Mister") == true);
