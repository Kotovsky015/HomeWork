using System.Globalization;

namespace ConsoleApp.Task4_Clinic;

public class Task4Clinic
{
    public void Run()
    {
        int hours;
        int minutes;
        int peopleInLine;
        int totalInMinutes;

        const int WaitingTimeInMinutes = 10;
        const int MinutesInHour = 60;


        Console.Write("Введите количство пациентов:");
        peopleInLine = Convert.ToInt32(Console.ReadLine());

        totalInMinutes = peopleInLine * WaitingTimeInMinutes;
        hours = totalInMinutes / MinutesInHour;
        minutes = totalInMinutes % MinutesInHour;

        Console.WriteLine(
            $"Вы должны отстоять в очереди {hours} час и {minutes} минут");
    }
}