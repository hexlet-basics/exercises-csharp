#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.WhoIsThisHouseToStarks("Tally") == "friend");
PAssert.IsTrue(() => App.WhoIsThisHouseToStarks("Karstark") == "friend");
PAssert.IsTrue(() => App.WhoIsThisHouseToStarks("Lannister") == "enemy");
PAssert.IsTrue(() => App.WhoIsThisHouseToStarks("Martell") == "neutral");
PAssert.IsTrue(() => App.WhoIsThisHouseToStarks("undefined") == "neutral");
