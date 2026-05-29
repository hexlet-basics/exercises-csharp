#load "/src/Init.csx"
#load "/src/RedirectOutput.csx"
#load "Exercise.csx"

;

var output = capturedConsoleOutput.ToString().Trim();
Console.SetOut(originalStdOut);
var exerciseCode = File.ReadAllText("Exercise.csx");
var hasExpectedComment = System.Text.RegularExpressions.Regex.IsMatch(
    exerciseCode,
    @"^\s*//\s*You know nothing, Jon Snow!\s*$",
    System.Text.RegularExpressions.RegexOptions.Multiline
);

PowerAssert.PAssert.IsTrue(() => output == "");
PowerAssert.PAssert.IsTrue(() => hasExpectedComment);
