#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.MakeItFunny("I never look back", 3);
PowerAssert.PAssert.IsTrue(() => actual1 == "I NevEr LooK bAck");

var actual2 = App.MakeItFunny("hello", 2);
PowerAssert.PAssert.IsTrue(() => actual2 == "hElLo");
