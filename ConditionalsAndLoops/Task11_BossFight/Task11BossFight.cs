namespace ConditionalsAndLoops.Task11_BossFight;

public class Task11BossFight
{
    public void Run()
    {
        const string CommandSwordAttack = "1";
        const string CommandFireboltAttack = "2";
        const string CommandExplosionAttack = "3";
        const string CommandHealthAndManaPotion = "4";

        int bossLife = 150;
        int heroMaxLife = 100;
        int heroMaxMana = 100;
        int healthAndManaPotionCount = 3;

        Random rnd = new Random();

        bool canUseExplosion = false;

        while (true)
        {
            Console.WriteLine($"Boss Life: {bossLife}");
            Console.WriteLine();
            Console.WriteLine($"Hero Life: {heroMaxLife} \nHero Mana : {heroMaxMana}");
            Console.WriteLine($"Количество эликсира жизни: {healthAndManaPotionCount}");
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

            int swordAttackDamage;
            int fireboltAttackDamage;
            int explosionAttackDamage;

            switch (userInput)
            {
                case CommandSwordAttack:
                    Console.WriteLine("Вы атакуете: \"Обычная атака мечём\"");
                    swordAttackDamage = rnd.Next(5, 8);
                    bossLife -= swordAttackDamage;
                    Console.WriteLine($"Вы нанесли боссу:{swordAttackDamage}");
                    
                    break;
                case CommandFireboltAttack:

                    fireboltAttackDamage = rnd.Next(10, 15);
                    if (heroMaxMana >= 20)
                    {
                        heroMaxMana -= 20;
                        canUseExplosion = true;
                        Console.WriteLine($"Вы атакуете: \"Огненный шар\" {fireboltAttackDamage}");
                        bossLife -= fireboltAttackDamage;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно маны");
                    }
                    break;
                case CommandExplosionAttack:
                    explosionAttackDamage = rnd.Next(20, 30);
                    if (canUseExplosion)
                    {
                        bossLife -= explosionAttackDamage;
                        Console.WriteLine($"Вы атакуете: \"Взрыв\" {explosionAttackDamage}");
                        canUseExplosion = false;
                    }
                    else
                    {
                        Console.WriteLine("Необходимо выпустить \"Огненный шар\"");
                    }
                    break;
                case CommandHealthAndManaPotion:
                    if (healthAndManaPotionCount > 0)
                    {
                        heroMaxLife += 20;
                        heroMaxMana += 20;

                        if (heroMaxLife > 100)
                        {
                            heroMaxLife = 100;
                        }

                        if (heroMaxMana > 100)
                        {
                            heroMaxMana = 100;
                        }

                        healthAndManaPotionCount--;
                        Console.WriteLine(
                            $"Жизнь восстановлена {heroMaxLife} + 20 \nМана восстановлена {heroMaxMana} + 20");
                        Console.WriteLine($"Осталось {healthAndManaPotionCount} бутылок восстановления жизни и маны.");
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

            int bossAttackDamage;
            bossAttackDamage = rnd.Next(9, 15);
            heroMaxLife -= bossAttackDamage;

            Console.WriteLine($"Босс атакует вас:{bossAttackDamage}");

            if (bossLife <= 0 && heroMaxLife <= 0)
            {
                Console.WriteLine("Ничья. Вы оба мертвы");
                break;
            }
            else if (bossLife <= 0)
            {
                Console.WriteLine("Бос умер...");
                Console.WriteLine("Победа!");
                break;
            }
            else if (heroMaxLife <= 0)
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