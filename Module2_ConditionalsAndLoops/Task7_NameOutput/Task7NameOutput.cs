using System.Text;

namespace ConditionalsAndLoops.Task7_NameOutput;

public class Task7NameOutput
{
    public void Run()
    {
        Console.Write("Введи ваше имя:");
        string userInput = Console.ReadLine();

        Console.Write("Введите символ:");
        char inputSymbol = char.Parse(Console.ReadLine());
        
        int textLength = userInput.Length+2;
        
        StringBuilder result = new StringBuilder();
        
        string bottom = new String(inputSymbol, textLength);
        string middle = inputSymbol + userInput + inputSymbol;
        
        result.Append(bottom);
        result.AppendLine();
        result.Append(middle);
        result.AppendLine();
        result.Append(bottom);

        Console.WriteLine(result.ToString());
       
    }
}