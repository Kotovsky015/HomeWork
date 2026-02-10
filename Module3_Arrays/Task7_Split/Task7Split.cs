namespace Arrays.Task7_Split;

public class Task7Split
{
    public void Run()
    {
        string text = "Здорова Женя. Тут все ок !)";
        string[] words = text.Split(' ');

        foreach (string sub in words)
        {
            Console.WriteLine(sub);
        }
    }
}