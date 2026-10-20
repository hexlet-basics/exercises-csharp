
В программировании большое количество функций и методов имеют параметры, которые редко меняются. В C# для решения этой проблемы есть 2 способа: значение параметров по умолчанию и перегрузка методов. Сейчас мы рассмотрим выставление значений параметров по умолчанию.

Например мы хотим написать метод, который будет помогать северянам давать имена своим детям:

```cs
North.PickName("Sansa", "Stark"); // "Sansa Stark"
North.PickName("Meera", "Reed"); // "Meera Reed"

class North
{
    public static string PickName(string name, string surname)
    {
        return $"{name} {surname}";
    }
}
```

Если фамилия неизвестна, то мы хотим чтобы автоматически подставлялась фамилия _Snow_. Вот так это делается:

```cs
North.PickName("Bran", "Stark"); // "Bran Stark"
North.PickName("John"); // "John Snow"

class North
{
    public static string PickName(string name, string surname = "Snow")
    {
        return $"{name} {surname}";
    }
}
```

Параметр `surname` теперь имеет значение по умолчанию – "Snow", которое используется, если значение для этого параметра не было передано.

Параметров по умолчанию может быть несколько, но они должны быть всегда "правее" параметров, у которых умолчания нет.

<!-- check-csharp-blocks: expect-error — необязательный параметр перед обязательным -->
```cs
class North
{
    // error CS1737: Optional parameters must appear after all required parameters
    public static string PickName(string name = "Bran", string surname)
    {
        return $"{name} {surname}";
    }
}
```

А вот так ошибки не будет:

```cs
North.PickName(); // "Bran Snow"

class North
{
    public static string PickName(string name = "Bran", string surname = "Snow")
    {
        return $"{name} {surname}";
    }
}
```
