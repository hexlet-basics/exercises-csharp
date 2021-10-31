#r "nuget: FluentAssertions, 6.2.0"
#load "../../../RedirectOutput.csx"
#load "Exercise.csx"

using FluentAssertions;

var output = capturedConsoleOutput.ToString().Trim();
output.Should().Be("Hello, World!");




