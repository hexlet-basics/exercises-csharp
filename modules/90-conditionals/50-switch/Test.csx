#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.GetNumberExplanation(0);
PowerAssert.PAssert.IsTrue(() => actual1 == null);

var actual2 = App.GetNumberExplanation(666);
PowerAssert.PAssert.IsTrue(() => actual2 == "devil number");

var actual3 = App.GetNumberExplanation(42);
PowerAssert.PAssert.IsTrue(() => actual3 == "answer for everything");

var actual4 = App.GetNumberExplanation(7);
PowerAssert.PAssert.IsTrue(() => actual4 == "prime number");
