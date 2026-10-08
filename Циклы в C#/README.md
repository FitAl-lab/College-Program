# Практическая работа №4: Циклические конструкции в C#

**Работу выполняли:** Филаткин А. С.,

![Скрин игры]([file:///C:/Users/user/Pictures/Screenshots/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202026-10-08%20053306.png](https://github.com/FitAl-lab/College-Program/blob/main/%D0%A6%D0%B8%D0%BA%D0%BB%D1%8B%20%D0%B2%20C%23/Screen/%D0%97%D0%B0%D0%B4%D0%B0%D0%BD%D0%B8%D0%B54.png))

```csharp
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int playerHp = 100;
        int playerMaxHp = 100;
        int favor = 10;
        int favorMax = 10;
        int healAmount = 15;
        int restoreAmount = 3;
        int restoreCount = 2;

        string[] enenmies = { "Бешеный волк", "Морозный великан", "Огненный змей" };
        int[] enemiesHp = { 60, 90, 120 };
        int[] enemiesMaxHp = { 60, 90, 120 };
        int[] enemiesDmgMin = { 8, 12, 16 };
        int[] enemiesDmgMax = { 14, 20, 26 };

        Random rnd = new Random();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.WriteLine("║      СКАНДИНАВСКИЙ ЭПОС: ВОИН-ЯРЛ            ║");
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Чтобы вступить в бой, воин, нажми на Enter...");
        Console.ReadLine();

        bool gameOver = false;

        for (int wave = 0; wave < enenmies.Length && !gameOver; wave++)
        {
            string enemyName = enenmies[wave];
            int enemyHp = enemiesHp[wave];
            int enemyMaxHp = enemiesMaxHp[wave];
            int eMin = enemiesDmgMin[wave];
            int eMax = enemiesDmgMax[wave];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine($"║      ВОЛНА {wave + 1}: {enemyName,-28}║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            while (playerHp > 0 && enemyHp > 0)
            {
                Console.Clear();
                ShowBars(playerHp, playerMaxHp, favor, favorMax, enemyName, enemyHp, enemyMaxHp);
                int action = GetAction(favor, healAmount, restoreAmount, restoreCount);
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        int dmg1 = rnd.Next(10, 18);
                        enemyHp -= dmg1;
                        Console.WriteLine($"Ярл наносит удар топором: {dmg1} урона.");
                        break;
                    case 2:
                        favor -= 10;
                        int dmg2 = rnd.Next(22, 34);
                        enemyHp -= dmg2;
                        Console.WriteLine($"Ярость Ярла: {dmg2} урона! Милость Одина: {favor}/{favorMax}");
                        break;
                    case 3:
                        favor -= 10;
                        playerHp += healAmount;
                        if (playerHp > playerMaxHp)
                        {
                            playerHp = playerMaxHp;
                        }
                        Console.WriteLine($"Один дарует {healAmount} здоровья. Милость: {favor}/{favorMax}. HP: {playerHp}/{playerMaxHp}");
                        break;
                    case 4:
                        restoreCount--;
                        favor += restoreAmount;
                        if (favor > favorMax)
                        {
                            favor = favorMax;
                        }
                        Console.WriteLine($"Молитва Одина: +{restoreAmount} милости. Осталось молитв: {restoreCount}. Милость: {favor}/{favorMax}");
                        break;
                }

                if (enemyHp <= 0)
                {
                    enemyHp = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{enemyName} повержен!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    break;
                }

                int enemyDmg = rnd.Next(eMin, eMax + 1);
                playerHp -= enemyDmg;
                if (playerHp < 0)
                {
                    playerHp = 0;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{enemyName} наносит {enemyDmg} урона. HP Ярла: {playerHp}/{playerMaxHp}");
                Console.ResetColor();
                Thread.Sleep(2000);
            }

            if (playerHp <= 0)
            {
                gameOver = true;
            }
        }

        Console.Clear();
        if (playerHp <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║         Ярл пал в бою.                       ║");
            Console.WriteLine("║         Вальгалла ждёт достойных.            ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║      Все враги повержены!                    ║");
            Console.WriteLine("║      Ярл одержал победу!                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();
        }
    }

    static void ShowBars(int playerHp, int playerMaxHp, int favor, int favorMax, string enemyName, int enemyHp, int EnemyMaxHp)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ярл HP: [");
        for (int i = 0; i < playerHp; i++) Console.Write("#");
        for (int i = 0; i < (playerMaxHp - playerHp); i++) Console.Write("-");
        Console.WriteLine($"] ({playerHp}/{playerMaxHp})");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Мана:   [");
        for (int m = 0; m < favor; m++) Console.Write("+");
        for (int m = 0; m < (favorMax - favor); m++) Console.Write("-");
        Console.WriteLine($"] ({favor}/{favorMax})");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"HP {enemyName}: [");
        for (int o = 0; o < enemyHp; o++) Console.Write("#");
        for (int o = 0; o < (EnemyMaxHp - enemyHp); o++) Console.Write("-");
        Console.WriteLine($"] ({enemyHp}/{EnemyMaxHp})");
        Console.ResetColor();
        Console.WriteLine();
    }

    static int GetAction(int favor, int healAmount, int restoreAmount, int restoreCount)
    {
        int action;
        bool isValid;

        do
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 — Атака");
            Console.WriteLine("2 — Яростная атака (10 маны)");
            Console.WriteLine($"3 — Лечение (+{healAmount}, 10 маны)");
            Console.WriteLine($"4 — Молитва Одина (+{restoreAmount} маны, осталось: {restoreCount})");
            Console.WriteLine();
            Console.Write("Ваш выбор: ");

            isValid = int.TryParse(Console.ReadLine(), out action) && action >= 1 && action <= 4;

            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка: введите цифру от 1 до 4!\n");
                Console.ResetColor();
            }
            else if (action == 2 && favor < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка: недостаточно маны для ярости!\n");
                Console.ResetColor();
                isValid = false;
            }
            else if (action == 3 && favor < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка: недостаточно маны для лечения!\n");
                Console.ResetColor();
                isValid = false;
            }
            else if (action == 4 && restoreCount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка: молитва больше недоступна!\n");
                Console.ResetColor();
                isValid = false;
            }
        } while (!isValid);

        return action;
    }
}
```
