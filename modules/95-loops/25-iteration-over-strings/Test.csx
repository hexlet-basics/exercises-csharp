#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

App.PrintReversedNameBySymbol("Hexlet");

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => output == "t\ne\nl\nx\ne\nH");
