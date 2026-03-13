#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.HasChar("Renly", 'R');
PowerAssert.PAssert.IsTrue(() => actual1 == true);

var actual2 = App.HasChar("Renly", 'r');
PowerAssert.PAssert.IsTrue(() => actual2 == false);

var actual3 = App.HasChar("Tommy", 'm');
PowerAssert.PAssert.IsTrue(() => actual3 == true);

var actual4 = App.HasChar("Tommy", 'd');
PowerAssert.PAssert.IsTrue(() => actual4 == false);

var actual5 = App.HasChar("Tommy", 'y');
PowerAssert.PAssert.IsTrue(() => actual5 == true);
