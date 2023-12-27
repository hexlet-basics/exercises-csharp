
Реализуйте статический метод `FilterString()` в классе `App`, принимающую на вход строку и символ, и возвращающую новую строку, в которой удален переданный символ во всех его позициях.

Пример вызова:

```cs
var str = "If I look back I am lost";
App.FilterString(str, 'I'); // "f  look back  am lost"
App.FilterString(str, 'o'); // "If I lk back I am lst"
```
