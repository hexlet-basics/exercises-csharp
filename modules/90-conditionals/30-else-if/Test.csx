#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.WhoIsThisHouseToStarks("Tally");
PowerAssert.PAssert.IsTrue(() => actual1 == "friend");

var actual2 = App.WhoIsThisHouseToStarks("Karstark");
PowerAssert.PAssert.IsTrue(() => actual2 == "friend");

var actual3 = App.WhoIsThisHouseToStarks("Lannister");
PowerAssert.PAssert.IsTrue(() => actual3 == "enemy");

var actual4 = App.WhoIsThisHouseToStarks("Martell");
PowerAssert.PAssert.IsTrue(() => actual4 == "neutral");

var actual5 = App.WhoIsThisHouseToStarks("undefined");
PowerAssert.PAssert.IsTrue(() => actual5 == "neutral");
