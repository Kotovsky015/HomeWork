namespace ConditionalsAndLoops.Task6_CurrencyExchange;

public class Task6CurrencyExchange
{
    public void Run()
    {
        const int EurToUsd = 10;
        const int RubToEur = 11;
        const int RubToUsd = 12;

        const string CommandEurExchangeToUsd = "1";
        const string CommandUsdExchangeToEur = "2";
        const string CommandRubExchangeToUsd = "3";
        const string CommandUsdExchangeToRub = "4";
        const string CommandEurExchangeToRub = "5";
        const string CommandRubExchangeToEur = "6";
        const string CommandExit = "7";

        float eurInWallet;
        float usdInWallet;
        float rubInWallet;
        float exchangeCurrencyCount;

        string userInput;

        bool isWork = true;

        Console.Write("Введите количество EUR:");
        eurInWallet = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество USD:");
        usdInWallet = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество RUB:");
        rubInWallet = Convert.ToSingle(Console.ReadLine());

        while (isWork)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine($"{CommandEurExchangeToUsd} - Обменять евро на доллары.");
            Console.WriteLine($"{CommandUsdExchangeToEur} - Обменять доллары на евро.");
            Console.WriteLine($"{CommandRubExchangeToUsd} - Обменять рубли на доллары.");
            Console.WriteLine($"{CommandUsdExchangeToRub} - Обменять доллары на рубли.");
            Console.WriteLine($"{CommandEurExchangeToRub} - Обменять евро на рубли.");
            Console.WriteLine($"{CommandRubExchangeToEur} - Обменять рубли на евро.");
            Console.WriteLine($"{CommandExit} - Выход.");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandEurExchangeToUsd:
                    Console.Write("Введите колько евро хотите обменять на доллары:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount * EurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandUsdExchangeToEur:
                    Console.Write("Введите колько долларов хотите обменять на евро:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / EurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandRubExchangeToUsd:
                    Console.Write("Введите колько рублей хотите обменять на доллары:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount * RubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandUsdExchangeToRub:
                    Console.Write("Введите колько долларов хотите обменять на рубли:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount / RubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandEurExchangeToRub:
                    Console.Write("Введите колько евро хотите обменять на рубли:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount * RubToEur;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandRubExchangeToEur:
                    Console.Write("Введите колько рублей хотите обменять на евро:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / RubToEur;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно средств для обмена");
                    }

                    Console.WriteLine($"usd {usdInWallet}. eur {eurInWallet}. rub {rubInWallet} ");
                    break;
                case CommandExit:
                    isWork = false;
                    break;
            }
        }
    }
}