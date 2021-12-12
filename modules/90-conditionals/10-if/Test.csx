#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.GetSentenceTone("normal") == "normal");
PAssert.IsTrue(() => App.GetSentenceTone("normal?") == "normal");
PAssert.IsTrue(() => App.GetSentenceTone("NoRmal?") == "normal");
PAssert.IsTrue(() => App.GetSentenceTone("SCREAM") == "scream");
PAssert.IsTrue(() => App.GetSentenceTone("SCREAM!") == "scream");
