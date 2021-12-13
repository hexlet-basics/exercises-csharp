#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.Reverse("Bran") == "narB");
PAssert.IsTrue(() => App.Reverse("") == "");
PAssert.IsTrue(() => App.Reverse("Hexlet") == "telxeH");
