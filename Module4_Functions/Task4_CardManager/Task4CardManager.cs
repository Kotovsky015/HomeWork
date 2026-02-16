namespace Module4_Functions.Task4_CardManager;

public class Task4CardManager
{
    public void Run()
    {
        const int CommandAddEmployee = 1;
        const int CommandShowInfo = 2;
        const int CommandRemoveEmployee = 3;
        const int CommandFirstName = 4;
        const int CommandExit = 5;

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
            Console.WriteLine("1.Добавить досье");
            Console.WriteLine("2.Вывести все досье");
            Console.WriteLine("3.Удалить досье");
            Console.WriteLine("4.Поиск по фамилии");
            Console.WriteLine("5.Выход");

            string userInput = Console.ReadLine();
            int userChoise = 0;
            bool isNumber = int.TryParse(userInput, out userChoise);

            if (!isNumber)
            {
                Console.WriteLine("Введите число!");
                Console.ReadKey();
                continue;
            }

            switch (userChoise)
            {
                case CommandAddEmployee:
                    AddEmployee(ref employees, ref positions);
                    break;

                case CommandShowInfo:
                    ShowInfo(employees, positions);
                    break;

                case CommandRemoveEmployee:
                    ShowInfo(employees, positions);
                    RemoveEmployee(ref employees, ref positions);
                    break;

                case CommandFirstName:
                    FindByLatsName(employees, positions);
                    break;

                case CommandExit:
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Нет такой команды");
                    break;
            }

            Console.ReadKey();
        }
    }

    void AddEmployee(ref string[] addEmployee, ref string[] addPosition)
    {
        Console.WriteLine("Введите ФИО");
        string inputEmployee = Console.ReadLine();
        Console.WriteLine("Введите должность");
        string inputPosition = Console.ReadLine();

        addEmployee = AddSlot(addEmployee);
        addPosition = AddSlot(addPosition);

        addEmployee[addEmployee.Length - 1] = inputEmployee;
        addPosition[addPosition.Length - 1] = inputPosition;
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
        Console.WriteLine("Введите номер досье для удаления");
        
        string input = Console.ReadLine();
        int index = 0;
        bool isNumber = int.TryParse(input, out index);

        if (!isNumber)
        {
            Console.WriteLine("Введите число");
        }
        else
        {
            index = Convert.ToInt32(input) - 1;

            if (index > 0 && index > employee.Length - 1)
            {
                Console.WriteLine("Нет такого индекса");
            }
            else
            {
                string[] tempEmployee = new string[employee.Length - 1];
                string[] tempPosition = new string[position.Length - 1];
                if (index >= 0 && index < employee.Length)
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
        }
    }

    void ShowInfo(string[] employees, string[] positions)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{i + 1} {employees[i]}-{positions[i]}");
        }
    }

    void FindByLatsName(string[] employees, string[] positions)
    {
        Console.WriteLine("Введите фамилию");
        
        string firstName = Console.ReadLine();
        int index = 0;

        for (int i = 0; i < employees.Length; i++)
        {
            string temp = employees[i].Split()[0];

            if (temp == firstName)
            {
                index = i;
                Console.WriteLine($"{index + 1} {employees[index]}-{positions[index]}");
            }
        }
    }
}