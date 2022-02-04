#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.Reverse("Bran");
PAssert.IsTrue(() => actual1 == "narB");

var actual2 = App.Reverse("");
PAssert.IsTrue(() => actual2 == "");

var actual3 = App.Reverse("Hexlet");
PAssert.IsTrue(() => actual3 == "telxeH");
