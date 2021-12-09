#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var result1 = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 17);
PAssert.IsTrue(() => result1 == "Три закона робото...");

var result2 = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим");
PAssert.IsTrue(() => result2 == "Три закона...");
