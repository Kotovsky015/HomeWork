namespace Arrays.Task9_ParentheticalExpression;

public class Task9BracketChecker
{
    public void Run()
    {
        string text = "(((())";
        int maxDepth = 0;
        int depth = 0;

        foreach (char value in text)
        {
            if (value == '(')
            {
                depth++;
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }
            else if (value == ')')
            {
                depth--;
                if (depth < 0)
                {
                    Console.WriteLine($"Строка не корректная");
                    break;
                }
            }
        }

        if (depth == 0)
        {
            Console.WriteLine($"Строка корректная и максимум глубины равняется {maxDepth}");
        }
        else
        {
            Console.WriteLine($"Строка не корректная");
        }
    }
}