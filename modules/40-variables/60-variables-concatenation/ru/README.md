
Переменные и конкатенацию можно объединять. Синтаксически ничего не меняется: мы умеем конкатенировать (склеивать) две строки:

```cs
var what = "Kings" + "road";
Console.WriteLine(what); // => "Kingsroad"
```

А значит сумеем конкатенировать строку и одну переменную, в которой записана строка:

```cs
var first = "Kings";
var what = first + "road";

Console.WriteLine(what); // => "Kingsroad"
```

И даже конкатенировать две переменные, в которых записаны строки:

```cs
var first = "Kings";
var last = "road";
var what = first + last;

Console.WriteLine(what); //=> "Kingsroad"
```
