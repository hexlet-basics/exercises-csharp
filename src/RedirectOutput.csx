using System;

var originalStdOut = Console.Out;
var capturedConsoleOutput = new StringWriter();
Console.SetOut(capturedConsoleOutput);
