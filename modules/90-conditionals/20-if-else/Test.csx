#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.NormalizeUrl("yandex.ru");
PAssert.IsTrue(() => actual1 == "https://yandex.ru");

var actual2 = App.NormalizeUrl("https://yandex.ru");
PAssert.IsTrue(() => actual2 == "https://yandex.ru");
