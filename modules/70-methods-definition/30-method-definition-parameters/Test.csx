#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 48);

PowerAssert.PAssert.IsTrue(() => actual == "Три закона робототехники придумали кожаные мешки...");
