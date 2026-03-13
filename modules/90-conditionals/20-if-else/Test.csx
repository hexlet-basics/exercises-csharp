#load "/src/Init.csx"
#load "Exercise.csx"

;
using PowerAssert;

var actual1 = App.NormalizeUrl("yandex.ru");
PAssert.IsTrue(() => actual1 == "https://yandex.ru");

var actual2 = App.NormalizeUrl("http://yandex.ru");
PAssert.IsTrue(() => actual2 == "https://yandex.ru");

var actual3 = App.NormalizeUrl("https://yandex.ru");
PAssert.IsTrue(() => actual3 == "https://yandex.ru");

var actual4 = App.NormalizeUrl("httpsecurity.com");
PAssert.IsTrue(() => actual4 == "https://httpsecurity.com");

var actual5 = App.NormalizeUrl("https://httpbin.org/redirect-to?url=http://google.com");
PAssert.IsTrue(() => actual5 == "https://httpbin.org/redirect-to?url=http://google.com");

var actual6 = App.NormalizeUrl("httpbin.org/redirect-to?url=https://google.com");
PAssert.IsTrue(() => actual6 == "https://httpbin.org/redirect-to?url=https://google.com");

var actual7 = App.NormalizeUrl("httpbin.org/redirect-to?url=http://google.com");
PAssert.IsTrue(() => actual7 == "https://httpbin.org/redirect-to?url=http://google.com");
