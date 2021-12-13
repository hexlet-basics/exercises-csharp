#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.CountChars("axe", 'a') == 1);
PAssert.IsTrue(() => App.CountChars("", 'a') == 0);
PAssert.IsTrue(() => App.CountChars("OpPa", 'p') == 2);
PAssert.IsTrue(() => App.CountChars("OpPa", 'P') == 2);
