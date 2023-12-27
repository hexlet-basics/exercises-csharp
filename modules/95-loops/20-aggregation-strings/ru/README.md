
Агрегация применяется не только к числам, но и к строкам. Это такие задачи, в которых строка формируется динамически, то есть заранее неизвестно, какого она размера и что будет содержать.

Представьте себе метод, который умеет «умножать» строку, то есть она повторяет её указанное количество раз:

```cs
App.Repeat("hexlet", 3); // "hexlethexlethexlet"
```

Принцип работы этого метода довольно простой: в цикле происходит «наращивание» строки указанное количество раз:

```cs
class App
{
    public static string Repeat(string text, int times)
    {
        // Нейтральный элемент для строк – пустая строка
        var result = "";
        var i = 1;

        while (i <= times)
        {
            // Каждый раз добавляем строку к результату
            result = result + text;
            i = i + 1;
        }

        return result;
    }
}
```

Распишем выполнение этого кода по шагам:

```cs
// Для вызова App.Repeat("hexlet", 3);
var result = "";
result = result + "hexlet"; // "hexlet"
result = result + "hexlet"; // "hexlethexlet"
result = result + "hexlet"; // "hexlethexlethexlet"
```
