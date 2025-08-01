
Инструкция — это команда для компьютера. Код на C# — это набор инструкций, которые, обычно, отделяются друг от друга символом `;`. Вот пример кода с двумя инструкциями:

```cs
Console.WriteLine("Mother of Dragons");
Console.WriteLine("Dracarys!");
```

При запуске этого кода на экран последовательно выводятся два предложения:

```text
Mother of Dragons
Dracarys!
```

Почему это важно знать? Инструкция — это единица исполнения. Программа которая запускает код на C#, выполняет инструкции строго по очереди. И мы, как разработчики, должны понимать этот порядок и уметь мысленно разделять программу на независимые части, удобные для анализа.

Теоретически инструкции можно написать последовательно друг за другом без переноса на новую строчку:

```cs
Console.WriteLine("Mother of Dragons."); Console.WriteLine("Dracarys!");
```

Результат на экране будет таким же, но на практике такой подход считается плохим.
