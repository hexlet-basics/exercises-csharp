#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual = App.GetCurrentYear();
PAssert.IsTrue(() => actual == DateTime.Now.Year);
