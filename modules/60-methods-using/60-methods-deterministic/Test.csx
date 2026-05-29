#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

;

var output = capturedConsoleOutput.ToString().Trim();
var outputAsNumber = Convert.ToInt32(output);
Console.SetOut(originalStdOut);
Console.Write(capturedConsoleOutput);

PowerAssert.PAssert.IsTrue(() => outputAsNumber >= 0 && outputAsNumber < 10);
