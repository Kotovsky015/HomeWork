namespace ConditionalsAndLoops.Task11_BossFight;

public class Task11BossFight
{
    public void Run()
    {
        const string CommandSwordAttack = "1";
        const string CommandFireboltAttack = "2";
        const string CommandExplosionAttack = "3";
        const string CommandHealthAndManaPotion = "4";

        int bossHealth = 150;
        int heroMaxHealth = 100;
        int heroMaxMana = 100;
        int recoveryPotion = 3;

        Random randomAttackRange = new Random();

        bool canUseExplosion = false;

        while (true)
        {
            Console.WriteLine($"Boss Life: {bossHealth}");
            Console.WriteLine();
            Console.WriteLine($"Hero Life: {heroMaxHealth} \nHero Mana : {heroMaxMana}");
            Console.WriteLine($"Количество эликсира жизни: {recoveryPotion}");
            Console.WriteLine();
            Console.WriteLine("Вас атакует Босс...");
            Console.WriteLine();
            Console.WriteLine($"{CommandSwordAttack} - Обычная атака мечём.");
            Console.WriteLine($"{CommandFireboltAttack} - Огненный шар.");
            Console.WriteLine($"{CommandExplosionAttack} - Взрыв.");
            Console.WriteLine($"{CommandHealthAndManaPotion} - Восстановление 20 жизни, 20 маны.");
            Console.Write("Выберите действие:");

            string userInput;
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandSwordAttack:
                    int swordAttackDamage = randomAttackRange.Next(5, 8);
                    Console.WriteLine("Вы атакуете: \"Обычная атака мечём\"");
                    bossHealth -= swordAttackDamage;
                    Console.WriteLine($"Вы нанесли боссу:{swordAttackDamage}");
                    break;

                case CommandFireboltAttack:
                    int fireboltAttackDamage = randomAttackRange.Next(10, 15);
                    if (heroMaxMana >= 20)
                    {
                        heroMaxMana -= 20;
                        canUseExplosion = true;
                        Console.WriteLine($"Вы атакуете: \"Огненный шар\" {fireboltAttackDamage}");
                        bossHealth -= fireboltAttackDamage;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно маны");
                    }

                    break;

                case CommandExplosionAttack:
                    int explosionAttackDamage = randomAttackRange.Next(20, 30);
                    if (canUseExplosion)
                    {
                        bossHealth -= explosionAttackDamage;
                        Console.WriteLine($"Вы атакуете: \"Взрыв\" {explosionAttackDamage}");
                        canUseExplosion = false;
                    }
                    else
                    {
                        Console.WriteLine("Необходимо выпустить \"Огненный шар\"");
                    }

                    break;

                case CommandHealthAndManaPotion:
                    if (recoveryPotion > 0)
                    {
                        heroMaxHealth += 20;
                        heroMaxMana += 20;

                        if (heroMaxHealth > 100)
                        {
                            heroMaxHealth = 100;
                        }

                        if (heroMaxMana > 100)
                        {
                            heroMaxMana = 100;
                        }

                        recoveryPotion--;
                        Console.WriteLine(
                            $"Жизнь восстановлена {heroMaxHealth} + 20 \nМана восстановлена {heroMaxMana} + 20");
                        Console.WriteLine($"Осталось {recoveryPotion} бутылок восстановления жизни и маны.");
                    }
                    else
                    {
                        Console.WriteLine("Бутылки восстановления закончились");
                    }

                    break;

                default:
                    Console.WriteLine("Не верная команда. Вы пропускаете ход");
                    break;
            }

            int bossAttackDamage = randomAttackRange.Next(9, 15);
            heroMaxHealth -= bossAttackDamage;

            Console.WriteLine($"Босс атакует вас:{bossAttackDamage}");

            if (bossHealth <= 0 && heroMaxHealth <= 0)
            {
                Console.WriteLine("Ничья. Вы оба мертвы");
                break;
            }
            else if (bossHealth <= 0)
            {
                Console.WriteLine("Бос умер...");
                Console.WriteLine("Победа!");
                break;
            }
            else if (heroMaxHealth <= 0)
            {
                Console.WriteLine("Вы погибли...");
                Console.WriteLine("Потрачено!");
                break;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}