using System.Globalization;

namespace Module5_Collections.Task1_Dictionary;

public class Task1Dictionary
{
    public void Run()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("Массив", "Структура данных для хранения набора элементов одного типа.");
        dictionary.Add("Метод", "Блок кода, который выполняет определённую задачу.");
        dictionary.Add("Переменная", "Именованная область памяти для хранения значения.");
        dictionary.Add("Цикл", "Конструкция для многократного выполнения кода.");
        dictionary.Add("Условие", "Проверка, которая определяет, какой код будет выполнен.");

        string userInput = Console.ReadLine();

        if (dictionary.TryGetValue(userInput, out userInput))
        {
            Console.WriteLine(userInput);
        }
        else
        {
            Console.WriteLine("Нету такого слова.");
        }
    }
}