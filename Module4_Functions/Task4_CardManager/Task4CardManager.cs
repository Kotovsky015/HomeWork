namespace Module4_Functions.Task4_CardManager;

public class Task4CardManager
{
    public void Run()
    {
        const int AddEmployeeCommand = 1;
        const int ShowInfoCommand = 2;
        const int RemoveEmployeeCommand = 3;
        const int FirstNameCommand = 4;
        const int ExitCommand = 5;

        string[] employees = new string[]
        {
            "Иванов Иван Иванович",
            "Петров Пётр Петрович",
            "Сидорова Анна Сергеевна",
            "Кузнецов Алексей Викторович",
            "Смирнова Ольга Владимировна",
            "Иванов Максим Иваныч"
        };

        string[] positions = new string[]
        {
            "Менеджер",
            "Бухгалтер",
            "Разработчик",
            "Системный администратор",
            "HR",
            "Уборщик"
        };

        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Выберите команду:");
            Console.WriteLine($"{AddEmployeeCommand}.Добавить досье ");
            Console.WriteLine($"{ShowInfoCommand}.Вывести все досье ");
            Console.WriteLine($"{RemoveEmployeeCommand}.Удалить досье ");
            Console.WriteLine($"{FirstNameCommand}.Поиск по фамилии ");
            Console.WriteLine($"{ExitCommand}.Выход ");

            string userInput = Console.ReadLine();
            int userNumber = 0;

            if (!int.TryParse(userInput, out userNumber))
            {
                Console.WriteLine("Введите число!");
                Console.ReadKey();
                continue;
            }

            switch (userNumber)
            {
                case AddEmployeeCommand:
                    AddEmployee(ref employees, ref positions);
                    break;

                case ShowInfoCommand:
                    ShowEmployeeInfo(employees, positions);
                    break;

                case RemoveEmployeeCommand:
                    ShowEmployeeInfo(employees, positions);
                    RemoveEmployee(ref employees, ref positions);
                    break;

                case FirstNameCommand:
                    FindByLastName(employees, positions);
                    break;

                case ExitCommand:
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Нет такой команды");
                    break;
            }

            Console.ReadKey();
        }
    }

    void AddEmployee(ref string[] employee, ref string[] position)
    {
        string inputEmployee = GetInput("Введите ФИО: ");
        string inputPosition = GetInput("Введите должность: ");

        employee = AddSlot(employee);
        position = AddSlot(position);

        employee[employee.Length - 1] = inputEmployee;
        position[position.Length - 1] = inputPosition;
    }

    string[] AddSlot(string[] array)
    {
        string[] tempArray = new string[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }

        return tempArray;
    }

    void RemoveEmployee(ref string[] employee, ref string[] position)
    {
        string input = GetInput("Введите номер досье для удаления: ");
        int index = 0;
        bool isNumber = int.TryParse(input, out index);

        if (!isNumber)
        {
            Console.WriteLine("Ошибка - Введите число: ");
            return;
        }

        if (index <= 0 || index > employee.Length)
        {
            Console.WriteLine("Нет такого индекса");
            return;
        }

        string[] tempEmployee = new string[employee.Length - 1];
        string[] tempPosition = new string[position.Length - 1];
        index -= 1;

        {
            for (int i = 0; i < index; i++)
            {
                tempEmployee[i] = employee[i];
                tempPosition[i] = position[i];
            }

            for (int i = index + 1; i < employee.Length; i++)
            {
                tempEmployee[i - 1] = employee[i];
                tempPosition[i - 1] = position[i];
            }

            employee = tempEmployee;
            position = tempPosition;
        }
    }

    void ShowEmployeeInfo(string[] employee, string[] position)
    {
        for (int i = 0; i < employee.Length; i++)
        {
            Console.WriteLine($"{i + 1} {employee[i]}-{position[i]}");
        }
    }

    void FindByLastName(string[] employee, string[] positions)
    {
        string lastName = GetInput("Введите фамилию: ");
        bool findLastName = false;

        for (int i = 0; i < employee.Length; i++)
        {
            string temp = employee[i].Split()[0];

            if (temp.Equals(lastName, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"{i + 1} {employee[i]}-{positions[i]}");
                findLastName = true;
            }
        }

        if (!findLastName)
        {
            Console.WriteLine("Нет такой фамилии в списке");
        }
    }

    string GetInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine().Trim();
    }
}