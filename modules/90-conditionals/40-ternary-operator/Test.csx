#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.ConvertString("hey");
PAssert.IsTrue(() => actual1 == "yeh");

var actual2 = App.ConvertString("Hey");
PAssert.IsTrue(() => actual2 == "Hey");

var actual3 = App.ConvertString("");
PAssert.IsTrue(() => actual3 == "");
