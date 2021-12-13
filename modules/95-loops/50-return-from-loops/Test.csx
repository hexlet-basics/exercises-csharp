#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.HasChar("Renly", 'R') == true);
PAssert.IsTrue(() => App.HasChar("Renly", 'r') == false);
PAssert.IsTrue(() => App.HasChar("Tommy", 'm') == true);
PAssert.IsTrue(() => App.HasChar("Tommy", 'd') == false);
PAssert.IsTrue(() => App.HasChar("Tommy", 'y') == true);
