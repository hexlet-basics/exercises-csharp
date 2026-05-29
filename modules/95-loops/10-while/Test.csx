#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

;

App.PrintNumbers(3);

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
Console.Write(capturedConsoleOutput);

PowerAssert.PAssert.IsTrue(() => output == "3\n2\n1\nfinished!");
