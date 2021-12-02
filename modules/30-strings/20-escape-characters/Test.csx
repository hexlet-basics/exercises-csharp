#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);

PAssert.IsTrue(() => output == "- Did Joffrey agree?\n- He did. He also said \"I love using \\n\".");
