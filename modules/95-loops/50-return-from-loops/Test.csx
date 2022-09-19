#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.HasChar("Renly", 'R');
PAssert.IsTrue(() => actual1 == true);

var actual2 = App.HasChar("Renly", 'r');
PAssert.IsTrue(() => actual2 == false);

var actual3 = App.HasChar("Tommy", 'm');
PAssert.IsTrue(() => actual3 == true);

var actual4 = App.HasChar("Tommy", 'd');
PAssert.IsTrue(() => actual4 == false);

var actual5 = App.HasChar("Tommy", 'y');
PAssert.IsTrue(() => actual5 == true);
