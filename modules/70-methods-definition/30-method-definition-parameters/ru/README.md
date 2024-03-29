
Методы могут не только возвращать значения, но и принимать их в виде параметров. С параметрами методов мы уже сталкивались много раз:

```cs
// Принимает на вход параметр любого типа
Console.WriteLine("я параметр");

// Принимает на вход два строковых параметра
// первый - что ищем, второй - на что меняем
"google".Replace("go", "mo"); // "moogle"

// Принимает на вход два числовых параметра
// первый - начальный индекс, второй - длина извлекаемой подстроки
"hexlet".Substring(1, 3); // "exl"
```

В этом уроке мы научимся создавать методы, которые принимают на вход параметры. Представим, что перед нами стоит задача реализовать статический метод `App.GetLastChar()`, возвращающий последний символ в строке, переданной ему на вход как параметр. Вот как будет выглядеть использование этого метода:

```cs
// Передача параметров напрямую без переменных
App.GetLastChar("Hexlet"); // 't'
App.GetLastChar("Goo"); // 'o'

// Передача параметров через переменные
var name1 = "Hexlet";
App.GetLastChar(name1); // 't'
var name2 = "Goo";
App.GetLastChar(name2); // 'o'
```

Из описания и примеров кода мы можем сделать следующие выводы:

* Нам нужно определить статический метод `GetLastChar()` в классе `App`
* Метод должен принимать на вход один параметр типа `string`
* Метод должен возвращать значение типа `char`

Определение метода:

```cs
class App
{
    public static char GetLastChar(string str)
    {
        // Вычисляем индекс последнего символа как длина строки - 1
        return str[str.Length - 1];
    }
}
```

Разберем его. `char` - говорит нам о типе возвращаемого значения. В скобках указывается тип параметра (`string`) и его имя (`str`). Так как внутри метода мы не знаем, с каким конкретно значением идет работа, то параметры всегда описываются как переменные. Имя параметра может быть любым, оно не связано с тем как вызывается метод. Главное чтобы это имя отражало смысл того значения, которое содержится внутри. Конкретное значение параметра будет зависеть от вызова этого метода.

Параметры в C# обязательны. Если попробовать вызвать метод без параметра, то компилятор выдаст ошибку:

```sh
App.GetLastChar(); // такой код не имеет смысла
There is no argument given that corresponds to the required formal parameter 'str' of 'App.GetLastChar(string)'
```

Точно таким же образом можно указывать два, три и более параметров. Каждый параметр отделяется от другого запятой.

```cs
class App
{
    // Метод по нахождению среднего числа
    // Возвращаемый тип double,
    // так как в результате деления может получиться дробное число
    public static double Average(int x, int y)
    {
        return (x + y) / 2.0;
    }
}

App.Average(1, 5); // 3.0
App.Average(1, 2); // 1.5
```
