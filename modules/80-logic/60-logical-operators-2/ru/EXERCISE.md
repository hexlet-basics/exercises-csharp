
Напишите метод `IsNeutralSoldier()`, который принимает на вход два аргумента:

1. Цвет доспехов (строка). Возможные варианты: `red`, `yellow`, `black`.
2. Цвет щита (строка). Возможные варианты: `red`, `yellow`, `black`.

Функция возвращает `true`, если _цвет доспехов не красный_ и _цвет щита чёрный_. В остальных случаях возвращает `false`.

Примеры вызова:

```cs
App.IsNeutralSoldier("yellow", "black"); // true
App.IsNeutralSoldier("red", "black");    // false
App.IsNeutralSoldier("red", "red");      // false
```
