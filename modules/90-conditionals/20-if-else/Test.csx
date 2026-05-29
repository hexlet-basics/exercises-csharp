#load "/src/Init.csx"
#load "Exercise.csx"

;

var actual1 = App.NormalizeUrl("yandex.ru");
PowerAssert.PAssert.IsTrue(() => actual1 == "https://yandex.ru");

var actual2 = App.NormalizeUrl("http://yandex.ru");
PowerAssert.PAssert.IsTrue(() => actual2 == "https://yandex.ru");

var actual3 = App.NormalizeUrl("https://yandex.ru");
PowerAssert.PAssert.IsTrue(() => actual3 == "https://yandex.ru");

var actual4 = App.NormalizeUrl("httpsecurity.com");
PowerAssert.PAssert.IsTrue(() => actual4 == "https://httpsecurity.com");

var actual5 = App.NormalizeUrl("https://httpbin.org/redirect-to?url=http://google.com");
PowerAssert.PAssert.IsTrue(() => actual5 == "https://httpbin.org/redirect-to?url=http://google.com");

var actual6 = App.NormalizeUrl("httpbin.org/redirect-to?url=https://google.com");
PowerAssert.PAssert.IsTrue(() => actual6 == "https://httpbin.org/redirect-to?url=https://google.com");

var actual7 = App.NormalizeUrl("httpbin.org/redirect-to?url=http://google.com");
PowerAssert.PAssert.IsTrue(() => actual7 == "https://httpbin.org/redirect-to?url=http://google.com");
