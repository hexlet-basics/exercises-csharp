#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.CountChars("axe", 'a');
PowerAssert.PAssert.IsTrue(() => actual1 == 1);

var actual2 = App.CountChars("", 'a');
PowerAssert.PAssert.IsTrue(() => actual2 == 0);

var actual3 = App.CountChars("OpPa", 'p');
PowerAssert.PAssert.IsTrue(() => actual3 == 2);

var actual4 = App.CountChars("OpPa", 'P');
PowerAssert.PAssert.IsTrue(() => actual4 == 2);
