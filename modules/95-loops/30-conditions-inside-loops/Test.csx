#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.CountChars("axe", 'a');
PAssert.IsTrue(() => actual1 == 1);

var actual2 = App.CountChars("", 'a');
PAssert.IsTrue(() => actual2 == 0);

var actual3 = App.CountChars("OpPa", 'p');
PAssert.IsTrue(() => actual3 == 2);

var actual4 = App.CountChars("OpPa", 'P');
PAssert.IsTrue(() => actual4 == 2);
