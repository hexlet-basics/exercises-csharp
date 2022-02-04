#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 48);

PAssert.IsTrue(() => actual == "Три закона робототехники придумали кожаные мешки...");
