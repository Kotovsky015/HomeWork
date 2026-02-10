namespace Arrays.Task9_ParentheticalExpression;

public class Task9ParentheticalExpression
{
    public void Run()
    {
        string value = "(((())";
        int maxDepth = 0;
        int depth = 0;

        foreach (char c in value)
        {
            if (c == '(')
            {
                depth++;
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }
            else if (c == ')')
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