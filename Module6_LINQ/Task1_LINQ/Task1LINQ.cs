namespace Module6_LINQ.Task1_LINQ;

public class Task1LINQ
{
    public void Run()
    {
        /*
         * Дана коллекция List<int> numbers. Написать одно выражение где:
         * Выбрать все чётные числа.
         * Выбрать все числа больше заданного порога threshold.
         */
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int threshold = 5;
        var evenNumber = numbers.Where(n => n % 2 == 0);
        var thresholdNumber = numbers.Where(n => n >= threshold);

        /*
         * Дана коллекция List<string> words. Написать одно выражения где:
         * Преобразовать каждую строку в верхний регистр.
         * Потом получить длины всех строк.
         */

        List<string> words = new List<string>() { "poh", "vazz", "testat", "test3", "tes", "test", "te" };

        var upperCaseResult = words.Select(n => n.ToUpper());
        var wordsCountResult = words.Select(n => n.Length);

        /*
         * Дана коллекция List<int> numbersWithDuplicates.
         * Получите список уникальных значений, используя только LINQ выражения (не хэшсет)
         */
        List<int> numbersWithDuplicates = new List<int> { 5, 3, 8, 5, 12, 3, 7, 8, 10, 5 };

        var uniqueValues = numbersWithDuplicates.Distinct();

        /*
         * Даны List<string> emails. Написать одно выражения где:
         * Найти первый адрес, который заканчивается на "@gmail.com"
         * Перед этим проверить, есть ли вообще такой элемент
         */
        List<string> emails = new List<string>
        {
            "alice@yahoo.com", "bob@outlook.com", "charlie@gmail.com", "david@hotmail.com", "eve@company.com",
            "vddvdv@gmail.com"
        };

        if (emails.Any(p => p.Contains("@gmail")))
        {
            var emailResult = emails.FirstOrDefault(p => p.Contains("@gmail"));
        }

        /*
         * Даны List<string> names. Написать одно выражения где:
         * Отсортировать по алфавиту
         * Отсортированное по алфавиту отсортировать по длине строки
         */

        List<string> names = new List<string>
            { "Eve", "Charlie", "Alice", "Ivan", "Julia", "Bob", "Hannah", "Frank", "David", "Grace" };
        
        
    }
}