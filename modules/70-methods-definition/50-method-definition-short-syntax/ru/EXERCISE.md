Реализуйте статический метод `Capitalize()` в сокращённой форме, через стрелку `=>`. Метод принимает непустую строку и возвращает её с первой буквой в верхнем регистре.

```csharp
App.Capitalize("arya"); // "Arya"
App.Capitalize("hello, world"); // "Hello, world"
```

Подстроку возвращает метод `Substring()`, а метод `ToUpper()` переводит строку в верхний регистр.

```csharp
"welcome".Substring(2, 3); // "lco"
"welcome".Substring(1); // "elcome"
"welcome".ToUpper(); // "WELCOME"
```
