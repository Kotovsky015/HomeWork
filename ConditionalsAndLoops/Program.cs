// See https://aka.ms/new-console-template for more information


using ConditionalsAndLoops.Task1_Cycles;
using ConditionalsAndLoops.Task2_ExitControll;
using ConditionalsAndLoops.Task3_Sequence;
using ConditionalsAndLoops.Task4_SumOfNumbers;
using ConditionalsAndLoops.Task5_ConsoleMenu;

internal class Program
{
    static void Main(string[] args)
    {
       Task5ConsoleMenu task5 = new Task5ConsoleMenu();
       task5.Run();
    }
}