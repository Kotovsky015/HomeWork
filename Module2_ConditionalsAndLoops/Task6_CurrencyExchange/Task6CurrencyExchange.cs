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

        const string USDSymbol = "USD";
        const string EURSymbol = "EUR";
        const string RUBSymbol = "RUB";

        const string ErrorMessage = "Not enough money!";

        bool isWork = true;

        Console.Write($"Введите количество {EURSymbol}:");
        float eurInWallet = Convert.ToSingle(Console.ReadLine());

        Console.Write($"Введите количество {USDSymbol}:");
        float usdInWallet = Convert.ToSingle(Console.ReadLine());

        Console.Write($"Введите количество {RUBSymbol}:");
        float rubInWallet = Convert.ToSingle(Console.ReadLine());

        while (isWork)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine($"{CommandEurExchangeToUsd} - Обменять {EURSymbol} на {USDSymbol}.");
            Console.WriteLine($"{CommandUsdExchangeToEur} - Обменять {USDSymbol} на {EURSymbol}.");
            Console.WriteLine($"{CommandRubExchangeToUsd} - Обменять {RUBSymbol} на {USDSymbol}.");
            Console.WriteLine($"{CommandUsdExchangeToRub} - Обменять {USDSymbol} на {RUBSymbol}.");
            Console.WriteLine($"{CommandEurExchangeToRub} - Обменять {EURSymbol} на {RUBSymbol}.");
            Console.WriteLine($"{CommandRubExchangeToEur} - Обменять {RUBSymbol} на {EURSymbol}.");
            Console.WriteLine($"{CommandExit} - Выход.");

            float exchangeCurrencyCount = 0f;
            string commandInput = Console.ReadLine();

            if (commandInput == CommandEurExchangeToUsd)
            {
                Console.Write($"Введите сколько {EURSymbol} хотите обменять на {USDSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (exchangeCurrencyCount <= eurInWallet)
                {
                    eurInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandUsdExchangeToEur)
            {
                Console.Write($"Введите сколько {USDSymbol} хотите обменять на {EURSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (exchangeCurrencyCount <= usdInWallet)
                {
                    usdInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandRubExchangeToUsd)
            {
                Console.Write($"Введите сколько {RUBSymbol} хотите обменять на {USDSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                if (exchangeCurrencyCount <= rubInWallet)
                {
                    rubInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandUsdExchangeToRub)
            {
                Console.Write($"Введите сколько {USDSymbol} хотите обменять на {RUBSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                if (exchangeCurrencyCount <= usdInWallet)
                {
                    usdInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandEurExchangeToRub)
            {
                Console.Write($"Введите сколько {EURSymbol} хотите обменять на {RUBSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                if (exchangeCurrencyCount <= eurInWallet)
                {
                    eurInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandRubExchangeToEur)
            {
                Console.Write($"Введите сколько {RUBSymbol} хотите обменять на {EURSymbol}:");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                if (exchangeCurrencyCount <= rubInWallet)
                {
                    rubInWallet -= exchangeCurrencyCount;
                }
                else
                {
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
            }
            else if (commandInput == CommandExit)
            {
                Console.WriteLine("Выход из приложения.");
            }
            else
            {
                Console.WriteLine("Нет такой команды.");
                continue;
            }

            switch (commandInput)
            {
                case CommandEurExchangeToUsd:
                    usdInWallet += exchangeCurrencyCount * EurToUsd;
                    break;
                case CommandUsdExchangeToEur:
                    eurInWallet += exchangeCurrencyCount / EurToUsd;
                    break;
                case CommandRubExchangeToUsd:
                    usdInWallet += exchangeCurrencyCount * RubToUsd;
                    break;
                case CommandUsdExchangeToRub:
                    rubInWallet += exchangeCurrencyCount / RubToUsd;
                    break;
                case CommandEurExchangeToRub:
                    rubInWallet += exchangeCurrencyCount * RubToEur;
                    break;
                case CommandRubExchangeToEur:
                    eurInWallet += exchangeCurrencyCount / RubToEur;
                    break;
                case CommandExit:
                    isWork = false;
                    break;
            }

            Console.WriteLine($"{USDSymbol}-{usdInWallet} {EURSymbol}-{eurInWallet} {RUBSymbol}-{rubInWallet}");
        }
    }
}