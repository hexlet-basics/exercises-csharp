#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var originalStdOut = Console.Out;
var capturedConsoleOutput = new StringWriter();
Console.SetOut(capturedConsoleOutput);

App.PrintMotto();
var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
Console.Write(capturedConsoleOutput);

PAssert.IsTrue(() => output == "Winter is coming");
