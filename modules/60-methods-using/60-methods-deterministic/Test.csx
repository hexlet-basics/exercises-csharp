#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
var outputAsNumber = int.Parse(output);
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => outputAsNumber >= 0 && outputAsNumber < 10);
