
Цикл `while` идеален для ситуаций, когда количество итераций неизвестно заранее, например, при поиске простого числа. Когда количество итераций известно, предпочтительнее использовать цикл `for`.

Посмотрим реализацию переворота строки через цикл `for`:

```cs
class App
{
    public static string ReverseString(string str)
    {
        var result = "";
        for (var i = 0; i < str.Length; i++)
        {
            result = str[i] + result;
        }

        return result;
    }
}
```

Можно читать так: *цикл с индексом `i` повторяется пока `i < str.Length` и после каждого шага увеличивает `i` на 1*.

В определении цикла `for` есть:

1. Начальное значение счётчика. Этот код выполняется ровно один раз перед первой итерацией.
2. Предикат — условие повторения циклов. Выполняется на каждой итерации. Точно так же как и в `while`
3. Описание изменения счётчика. Этот код выполняется в конце каждой итерации.

В остальном принцип работы точно такой же, как у цикла `while`.