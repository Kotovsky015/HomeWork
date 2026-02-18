namespace Module4_Functions.Task5_BraveNewWorld;

using System.IO;

public class Task5BraveNewWorld
{
    public void Run()
    {
    }

    char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines("Map.txt");
        char[,] map = new char[GetMaxLengthLine(file), file.Length];
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
}