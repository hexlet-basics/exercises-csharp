#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.Capitalize("arya");
PowerAssert.PAssert.IsTrue(() => actual1 == "Arya");

var actual2 = App.Capitalize("hello, world");
PowerAssert.PAssert.IsTrue(() => actual2 == "Hello, world");

var actual3 = App.Capitalize("jON");
PowerAssert.PAssert.IsTrue(() => actual3 == "JON");

var actual4 = App.Capitalize("a");
PowerAssert.PAssert.IsTrue(() => actual4 == "A");
