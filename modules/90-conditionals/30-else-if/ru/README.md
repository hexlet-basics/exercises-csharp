
В самой полной версии, конструкция `if` содержит не только ветку `else`, но и другие условные проверки с помощью `else if`. Такой вариант используется при большом количестве проверок, которые взаимоисключают друг друга.

```cs
if (/* что-то */)
{

}
else if (/* другая проверка */)
{

}
else if (/* другая проверка */)
{

}
else
{

}
```

Два момента. Ветка `else` может отсутствовать. Количество `else if` условий может быть любым, хоть одно, хоть десять.

Напишем для примера расширенный метод определяющий тип предложения. Он распознает три вида предложений:

```cs
class App
{
    public static string GetTypeOfSentence(string sentence)
    {
        var sentenceType = "";

        if (sentence.EndsWith('?'))
        {
            sentenceType = "question";
        }
        else if (sentence.EndsWith('!'))
        {
            sentenceType = "exclamation";
        }
        else
        {
            sentenceType = "general";
        }

        return "Sentence is " + sentenceType;
    }
}

App.GetTypeOfSentence("Who?"); // "Sentence is question"
App.GetTypeOfSentence("No");   // "Sentence is general"
App.GetTypeOfSentence("No!");  // "Sentence is exclamation"
```

Теперь все условия выстроены в единую конструкцию. `else if` — это «если не выполнено предыдущее условие, но выполнено текущее». Получается такая схема:

- если последний символ `?`, то `"question"`
- иначе, если последний символ `!`, то `"exclamation"`
- иначе `"general"`

Выполнится только один из блоков кода, относящихся ко всей конструкции `if`.
