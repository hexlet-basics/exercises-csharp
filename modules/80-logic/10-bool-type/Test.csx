#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.IsPensioner(70);
PAssert.IsTrue(() => actual1 == true);

var actual2 = App.IsPensioner(50);
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.IsPensioner(60);
PAssert.IsTrue(() => actual3 == true);

var actual4 = App.IsPensioner(59);
PAssert.IsTrue(() => actual4 == false);
