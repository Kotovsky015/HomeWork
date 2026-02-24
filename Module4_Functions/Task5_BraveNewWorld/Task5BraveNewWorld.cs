namespace Module4_Functions.Task5_BraveNewWorld;

using System.IO;

public class Task5BraveNewWorld
{
    public void Run()
    {
        const char PLAYER = '@';

        char[,] map = ReadMap("map.txt");
        ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

        int pacmanX = 1;
        int pacmanY = 1;

        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            DrawMap(map);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(pacmanX, pacmanY);
            Console.WriteLine(PLAYER);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pressedKey.KeyChar);

            pressedKey = Console.ReadKey();

            HandleInput(pressedKey, ref pacmanX, ref pacmanY, map);
        }
    }

    char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines("map.txt");
        char[,] map = new char[GetMaxLengthLine(file), file.Length];

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                map[x, y] = file[y][x];
            }
        }

        return map;
    }

    int GetMaxLengthLine(string[] lines)
    {
        int maxlength = lines[0].Length;

        foreach (var line in lines)
        {
            if (line.Length > maxlength)
                maxlength = line.Length;
        }

        return maxlength;
    }

    void DrawMap(char[,] map)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }

            Console.Write("\n");
        }
    }

    void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map)
    {
        int[] direction = GetDirection(pressedKey);

        int nextPacmanPositionX = pacmanX + direction[0];
        int nextPacmanPositionY = pacmanY + direction[1];

        if (map[nextPacmanPositionX, nextPacmanPositionY] != '#')
        {
            pacmanX = nextPacmanPositionX;
            pacmanY = nextPacmanPositionY;
        }
    }

    int[] GetDirection(ConsoleKeyInfo pressedKey)
    {
        int[] direction = { 0, 0 };

        switch (pressedKey.Key)
        {
            case ConsoleKey.UpArrow:
                direction[1] -= 1;
                break;
            case ConsoleKey.DownArrow:
                direction[1] += 1;
                break;
            case ConsoleKey.LeftArrow:
                direction[0] -= 1;
                break;
            case ConsoleKey.RightArrow:
                direction[0] += 1;
                break;
        }

        return direction;
    }
}