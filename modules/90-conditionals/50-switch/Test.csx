#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.GetNumberExplanation(0) == null);
PAssert.IsTrue(() => App.GetNumberExplanation(666) == "devil number");
PAssert.IsTrue(() => App.GetNumberExplanation(42) == "answer for everything");
PAssert.IsTrue(() => App.GetNumberExplanation(7) == "prime number");
