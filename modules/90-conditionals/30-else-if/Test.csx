#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

var actual1 = App.WhoIsThisHouseToStarks("Tally");
PAssert.IsTrue(() => actual1 == "friend");

var actual2 = App.WhoIsThisHouseToStarks("Karstark");
PAssert.IsTrue(() => actual2 == "friend");

var actual3 = App.WhoIsThisHouseToStarks("Lannister");
PAssert.IsTrue(() => actual3 == "enemy");

var actual4 = App.WhoIsThisHouseToStarks("Martell");
PAssert.IsTrue(() => actual4 == "neutral");

var actual5 = App.WhoIsThisHouseToStarks("undefined");
PAssert.IsTrue(() => actual5 == "neutral");
