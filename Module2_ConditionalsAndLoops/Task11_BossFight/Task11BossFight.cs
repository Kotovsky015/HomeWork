namespace ConditionalsAndLoops.Task11_BossFight;

public class Task11BossFight
{
    public void Run()
    {
        const string CommandSwordAttack = "1";
        const string CommandFireboltAttack = "2";
        const string CommandExplosionAttack = "3";
        const string CommandRecoveryPotion = "4";

        const int HeroMaxHealth = 100;
        const int HeroMaxMana = 100;
        const int PotionRecovery = 20;

        const int MinSwordAttack = 5;
        const int MaxSwordAttack = 8;
        const int MinFireBoltAttack = 10;
        const int MaxFireBoltAttack = 15;
        const int MinExplosionAttack = 20;
        const int MaxExplosionAttack = 30;
        const int MinBossAttack = 9;
        const int MaxBossAttack = 15;


        int bossHealth = 150;
        int heroHealth = 100;
        int heroMana = 100;
        int recoveryPotionCount = 3;

        Random randomAttackRange = new Random();

        bool canUseExplosion = false;

        while (true)
        {
            Console.WriteLine($"Boss Life: {bossHealth}");
            Console.WriteLine();
            Console.WriteLine($"Hero Life: {heroHealth} \nHero Mana : {heroMana}");
            Console.WriteLine($"Количество эликсира жизни: {recoveryPotionCount}");
            Console.WriteLine();
            Console.WriteLine("Вас атакует Босс...");
            Console.WriteLine();
            Console.WriteLine($"{CommandSwordAttack} - Обычная атака мечём.");
            Console.WriteLine($"{CommandFireboltAttack} - Огненный шар.");
            Console.WriteLine($"{CommandExplosionAttack} - Взрыв.");
            Console.WriteLine($"{CommandRecoveryPotion} - Восстановление 20 жизни, 20 маны.");
            Console.Write("Выберите действие:");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandSwordAttack:

                    int swordAttackDamage = randomAttackRange.Next(MinSwordAttack, MaxSwordAttack);
                    Console.WriteLine("Вы атакуете: \"Обычная атака мечём\"");
                    bossHealth -= swordAttackDamage;
                    Console.WriteLine($"Вы нанесли боссу:{swordAttackDamage}");
                    break;

                case CommandFireboltAttack:

                    int fireboltAttackDamage = randomAttackRange.Next(MinFireBoltAttack, MaxFireBoltAttack);
                    if (heroMana >= 20)
                    {
                        heroMana -= 20;
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

                    int explosionAttackDamage = randomAttackRange.Next(MinExplosionAttack, MaxExplosionAttack);
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

                case CommandRecoveryPotion:

                    if (recoveryPotionCount > 0)
                    {
                        heroHealth += PotionRecovery;
                        heroMana += PotionRecovery;

                        if (heroHealth > HeroMaxHealth)
                        {
                            heroHealth = HeroMaxHealth;
                        }

                        if (heroMana > HeroMaxMana)
                        {
                            heroMana = HeroMaxMana;
                        }

                        recoveryPotionCount--;
                        Console.WriteLine(
                            $"Жизнь восстановлена {heroHealth} + {PotionRecovery} \nМана восстановлена {heroMana} + {PotionRecovery}");
                        Console.WriteLine($"Осталось {recoveryPotionCount} бутылок восстановления жизни и маны.");
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

            int bossAttackDamage = randomAttackRange.Next(MinBossAttack, MaxBossAttack);
            heroHealth -= bossAttackDamage;

            Console.WriteLine($"Босс атакует вас:{bossAttackDamage}");

            if (bossHealth <= 0 && heroHealth <= 0)
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
            else if (heroHealth <= 0)
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