#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.FilterString("If I look back I am lost", 'I');
PAssert.IsTrue(() => actual1 == "f  look back  am lost");

var actual2 = App.FilterString("If I look back I am lost", 'o');
PAssert.IsTrue(() => actual2 == "If I lk back I am lst");

var actual3 = App.FilterString("zz zorro", 'z');
PAssert.IsTrue(() => actual3 == " orro");
