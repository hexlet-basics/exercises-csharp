#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 17);
PowerAssert.PAssert.IsTrue(() => actual1 == "Три закона робото...");

var actual2 = App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим");
PowerAssert.PAssert.IsTrue(() => actual2 == "Три закона...");
