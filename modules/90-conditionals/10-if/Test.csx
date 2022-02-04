#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.GetSentenceTone("normal");
PAssert.IsTrue(() => actual1 == "normal");

var actual2 = App.GetSentenceTone("normal?");
PAssert.IsTrue(() => actual2 == "normal");

var actual3 = App.GetSentenceTone("NoRmal?");
PAssert.IsTrue(() => actual3 == "normal");

var actual4 = App.GetSentenceTone("SCREAM");
PAssert.IsTrue(() => actual4 == "scream");

var actual5 = App.GetSentenceTone("SCREAM!");
PAssert.IsTrue(() => actual5 == "scream");
