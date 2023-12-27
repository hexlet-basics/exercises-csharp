
Реализуйте статический метод `App.HasChar()` в классе `App`, который проверяет (с учётом регистра), содержит ли строка указанную букву. Метод принимает два параметра:

* Строка
* Буква для поиска

```cs
App.HasChar("Renly", 'R'); // true
App.HasChar("Renly", 'r'); // false
App.HasChar("Tommy", 'm'); // true
App.HasChar("Tommy", 'd'); // false
```
