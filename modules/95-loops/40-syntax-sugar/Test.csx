#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.FilterString("If I look back I am lost", 'I') == "f  look back  am lost");
PAssert.IsTrue(() => App.FilterString("If I look back I am lost", 'o') == "If I lk back I am lst");
PAssert.IsTrue(() => App.FilterString("zz zorro", 'z') == " orro");
