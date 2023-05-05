#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
Console.Write(capturedConsoleOutput);

PAssert.IsTrue(() => output == "Hello Hexlet!");
