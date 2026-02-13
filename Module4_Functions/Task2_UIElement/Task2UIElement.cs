namespace Module4_Functions.Task2_UIElement;

public class Task2UIElement
{
    public void Run()
    {
        DrawBar(500, 1000, ConsoleColor.Green, 0);
        DrawBar(100, 100, ConsoleColor.DarkBlue, 1);
    }

    void DrawBar(int value, int maxValue, ConsoleColor color, int position)
    {
        const int BarWidth = 10;

        ConsoleColor defaultColor = Console.BackgroundColor;
        int valueDrawPercent = GetPercentage(value, maxValue);
        string bar = "";

        for (int i = 0; i < valueDrawPercent; i++)
        {
            bar += "#";
        }

        Console.SetCursorPosition(0, position);
        Console.Write('[');
        Console.BackgroundColor = color;
        Console.Write(bar);
        Console.BackgroundColor = defaultColor;

        bar = "";

        for (int i = valueDrawPercent; i < BarWidth; i++)
        {
            bar += " ";
        }

        Console.Write(bar + ']');
    }

    int GetPercentage(int value, int maxValue)
    {
        if (maxValue <= 0)
        {
            return 0;
        }

        double result = ((double)value / maxValue * 100) / 10;
        return Convert.ToInt32(result);
    }
}