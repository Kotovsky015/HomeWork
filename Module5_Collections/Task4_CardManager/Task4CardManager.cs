namespace Module5_Collections.Task4_CardManager;

public class Task4CardManager
{
    public void Run()
    {
        const string CREATE_EMPLOYEE_COMMAND = "1";
        const string SHOW_EMPLOYEE_COMMAND = "2";
        const string REMOVE_EMPLOYEE_COMMAND = "3";
        const string EXIT_COMMAND = "4";

        Dictionary<string, string> employee = new Dictionary<string, string>()
        {
            { "John Smith", "System Administrator" },
            { "Michael Johnson", "Backend Developer" },
            { "Emily Davis", "HR Manager" },
            { "Daniel Brown", "DevOps Engineer" },
            { "James Wilson", "Network Engineer" },
            { "Sophia Taylor", "Accountant" },
            { "William Anderson", "QA Engineer" }
        };

        bool isRunning = true;

        while (isRunning)
        {
            ShowMenu();
            string inputCommand = GetInput("Введите комманду:");

            switch (inputCommand)
            {
                case CREATE_EMPLOYEE_COMMAND:
                    AddEmployee(ref employee);
                    break;
                case SHOW_EMPLOYEE_COMMAND:
                    ShowEmployee(employee);
                    break;
                case REMOVE_EMPLOYEE_COMMAND:
                    RemoveEmployee(ref employee);
                    break;
                case EXIT_COMMAND:
                    isRunning = false;
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }

    void ShowMenu()
    {
        Console.WriteLine("1.Добавить сотрудника");
        Console.WriteLine("2.Показать всех сотрудников");
        Console.WriteLine("3.Удалить сотрудника");
        Console.WriteLine("4.Выход");
    }

    void AddEmployee(ref Dictionary<string, string> employee)
    {
        string employeeName = GetInput("Введите имя сотрудника");
        string employeePosition = GetInput("Введите должность");

        employee.Add(employeeName, employeePosition);
    }

    void ShowEmployee(Dictionary<string, string> employee)
    {
        foreach (KeyValuePair<string, string> item in employee)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }

    void RemoveEmployee(ref Dictionary<string, string> employee)
    {
        ShowEmployee(employee);
        string employeeName = GetInput("Выберите сотрудника для удаления");

        if (!employee.ContainsKey(employeeName))
        {
            Console.WriteLine("Нет такого сотрудника");
            return;
        }

        employee.Remove(employeeName);
    }

    string GetInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine().Trim();
    }
}