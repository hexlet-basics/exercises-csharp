#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.MakeItFunny("I never look back", 3) == "I NevEr LooK bAck");
PAssert.IsTrue(() => App.MakeItFunny("hello", 2) == "hElLo");
