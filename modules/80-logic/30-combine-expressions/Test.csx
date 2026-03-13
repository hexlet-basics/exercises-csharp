#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.IsInternationalPhone("89602223423");
PowerAssert.PAssert.IsTrue(() => actual1 == false);

var actual2 = App.IsInternationalPhone("+79602223423");
PowerAssert.PAssert.IsTrue(() => actual2 == true);
