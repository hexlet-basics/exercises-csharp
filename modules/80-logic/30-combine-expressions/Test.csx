#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.IsInternationalPhone("89602223423") == false);
PAssert.IsTrue(() => App.IsInternationalPhone("+79602223423") == true);
