#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => output == "King Balon the 6th has 102 rooms.");
