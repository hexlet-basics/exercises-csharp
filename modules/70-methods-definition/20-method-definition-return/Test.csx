#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var result = App.GetCurrentYear();

PAssert.IsTrue(() => result == DateTime.Now.Year);
