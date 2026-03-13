#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsPensioner(70);
PowerAssert.PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsPensioner(50);
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsPensioner(60);
PowerAssert.PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsPensioner(59);
PowerAssert.PAssert.IsTrue(() => actual4 == false);
