#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

;
using System.Text.RegularExpressions;
using PowerAssert;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
var exerciseCode = File.ReadAllText("Exercise.csx");
var hasExpectedComment = Regex.IsMatch(
    exerciseCode,
    @"^\s*//\s*You know nothing, Jon Snow!\s*$",
    RegexOptions.Multiline
);

PAssert.IsTrue(() => output == "");
PAssert.IsTrue(() => hasExpectedComment);
