#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var result = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 48);

PAssert.IsTrue(() => result == "Три закона робототехники придумали кожаные мешки...");
