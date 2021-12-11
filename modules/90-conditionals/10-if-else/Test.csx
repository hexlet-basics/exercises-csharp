#load "/src/Init.csx"
#load "Exercise.csx"

using PowerAssert;

PAssert.IsTrue(() => App.NormalizeUrl("yandex.ru") == "https://yandex.ru");
PAssert.IsTrue(() => App.NormalizeUrl("https://yandex.ru") == "https://yandex.ru");
