
На электронной карте Вестероса, которую реализовал Сэм, союзники Старков отображены зеленым кружком, враги — красным, а нейтральные семьи — серым.

Напишите для Сэма метод `WhoIsThisHouseToStarks()`, который принимает на вход фамилию семьи и возвращает одно из трех значений: `"friend"`, `"enemy"`, `"neutral"`.

Правила определения:

  * Друзья (`"friend"`): "Karstark", "Tally"
  * Враги (`"enemy"`): "Lannister", "Frey"
  * Любые другие семьи считаются нейтральными

Примеры вызова:

```cs
App.WhoIsThisHouseToStarks("Karstark"); // "friend"
App.WhoIsThisHouseToStarks("Frey");     // "enemy"
App.WhoIsThisHouseToStarks("Joar");     // "neutral"
App.WhoIsThisHouseToStarks("Ivanov");   // "neutral"
```
