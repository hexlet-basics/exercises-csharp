#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

App.PrintNumbers(3);

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => output == "3\n2\n1\nfinished!");
