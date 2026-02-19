namespace Module4_Functions.Task2_UIElement;

public class Task2UIElement
{
    public void Run()
    {
        int currentHealth = 500;
        int currentMana = 100;

        DrawHealthBar(currentHealth);
        DrawManaBar(currentMana);
    }

    void DrawHealthBar(int currentHealth)
    {
        const int MAX_HEALTH = 100;
        DrawBar(currentHealth, MAX_HEALTH, ConsoleColor.Green, 0);
    }

    void DrawManaBar(int currentMana)
    {
        const int MAX_MANA = 100;
        DrawBar(currentMana, MAX_MANA, ConsoleColor.Blue, 1);
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