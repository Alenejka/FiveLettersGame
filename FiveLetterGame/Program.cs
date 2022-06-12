using System;

namespace FiveLetterGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задаем правильное слово
            string guessWord = "автор"; 
            // вывод задания для пользователя в консоли
            Console.WriteLine("Введите слово из 5 букв.");
            // задан цикл для ввода вариантов ответа
            for (int i = 1; i < 4; i++)
            {
                // пользовательский ввод слова
                string? userWord = Console.ReadLine();
                // задан цикл вывода пользовательского слова по буквам
                for (int index = 0; index < userWord.Length; index++)
                {
                    // берем из слова которое ввел пользователь букву под номером index
                    char userLetter = userWord[index];
                    // берем из слова которое было загадано букву под номером index
                    char guessLetter = guessWord[index];
                    // задаем условие вывода слова по буквам. Если пользовательская буква равна правильной букве
                    if (userLetter == guessLetter)
                    {
                        // окрашиваем правильную букву в зеленый
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    // в ином случае
                    else
                    {
                        // окрашиваем не правильную букву в красный
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    // вывод текущей буквы 
                    Console.Write(userLetter);
                                 
                }
                // сброс окрашивания выводящих слов
              Console.ResetColor();

              // пустая строка
                Console.WriteLine($"");
                // условия вывода результата. Если пользовательское слово = правильному слову
                if (String.Compare(guessWord, userWord, StringComparison.OrdinalIgnoreCase) == 0)

                {
                    // выводим положительный результат
                    Console.WriteLine("Молодец");
                    // конец цикла
                    break;
                }
                // пользовательское слово  не равно правильному слову
                else
                {
                    // выводим отрицательный результат
                    Console.WriteLine($"Не молодец"); 
                }
             
            }

        }
    }
}
