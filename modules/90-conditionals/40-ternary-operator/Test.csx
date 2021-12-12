#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.ConvertString("hey") == "yeh");
PAssert.IsTrue(() => App.ConvertString("Hey") == "Hey");
