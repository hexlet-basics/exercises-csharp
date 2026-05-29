#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"

Console.WriteLine("warmup");

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
PowerAssert.PAssert.IsTrue(() => output == "warmup");
Console.WriteLine("dotnet script was warmed up");
