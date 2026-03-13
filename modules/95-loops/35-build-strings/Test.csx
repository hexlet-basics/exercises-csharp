#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.Reverse("Bran");
PowerAssert.PAssert.IsTrue(() => actual1 == "narB");

var actual2 = App.Reverse("");
PowerAssert.PAssert.IsTrue(() => actual2 == "");

var actual3 = App.Reverse("Hexlet");
PowerAssert.PAssert.IsTrue(() => actual3 == "telxeH");
