#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.ConvertString("hey");
PowerAssert.PAssert.IsTrue(() => actual1 == "yeh");

var actual2 = App.ConvertString("Hey");
PowerAssert.PAssert.IsTrue(() => actual2 == "Hey");

var actual3 = App.ConvertString("");
PowerAssert.PAssert.IsTrue(() => actual3 == "");
