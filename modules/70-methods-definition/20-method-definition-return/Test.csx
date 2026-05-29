#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual = App.GetCurrentYear();
PowerAssert.PAssert.IsTrue(() => actual == DateTime.Now.Year);
