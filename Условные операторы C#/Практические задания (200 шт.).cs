using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== ПРАКТИЧЕСКАЯ РАБОТА #3 =====\n");
            Console.WriteLine("1 - Примеры (1-4)");
            Console.WriteLine("2 - Раздел 1: базовые if / if-else (1-50)");
            Console.WriteLine("3 - Раздел 2: else if и диапазоны (51-100)");
            Console.WriteLine("4 - Раздел 3: составные условия &&, ||, ! (101-150)");
            Console.WriteLine("5 - Раздел 4: switch (151-200)");
            Console.WriteLine("0 - Выход\n");
            Console.Write("Выберите раздел: ");

            if (!int.TryParse(Console.ReadLine(), out int section)) continue;
            if (section == 0) return;

            Console.Write("Введите номер задания: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) continue;

            Console.WriteLine();

            switch (section)
            {
                case 1:
                    switch (task)
                    {
                        case 1: Example1(); break;
                        case 2: Example2(); break;
                        case 3: Example3(); break;
                        case 4: Example4(); break;
                        default: Console.WriteLine("Нет такого примера."); break;
                    }
                    break;
                case 2:
                    switch (task)
                    {
                        case 1: R1Task1(); break;
                        case 2: R1Task2(); break;
                        case 3: R1Task3(); break;
                        case 4: R1Task4(); break;
                        case 5: R1Task5(); break;
                        case 6: R1Task6(); break;
                        case 7: R1Task7(); break;
                        case 8: R1Task8(); break;
                        case 9: R1Task9(); break;
                        case 10: R1Task10(); break;
                        case 11: R1Task11(); break;
                        case 12: R1Task12(); break;
                        case 13: R1Task13(); break;
                        case 14: R1Task14(); break;
                        case 15: R1Task15(); break;
                        case 16: R1Task16(); break;
                        case 17: R1Task17(); break;
                        case 18: R1Task18(); break;
                        case 19: R1Task19(); break;
                        case 20: R1Task20(); break;
                        case 21: R1Task21(); break;
                        case 22: R1Task22(); break;
                        case 23: R1Task23(); break;
                        case 24: R1Task24(); break;
                        case 25: R1Task25(); break;
                        case 26: R1Task26(); break;
                        case 27: R1Task27(); break;
                        case 28: R1Task28(); break;
                        case 29: R1Task29(); break;
                        case 30: R1Task30(); break;
                        case 31: R1Task31(); break;
                        case 32: R1Task32(); break;
                        case 33: R1Task33(); break;
                        case 34: R1Task34(); break;
                        case 35: R1Task35(); break;
                        case 36: R1Task36(); break;
                        case 37: R1Task37(); break;
                        case 38: R1Task38(); break;
                        case 39: R1Task39(); break;
                        case 40: R1Task40(); break;
                        case 41: R1Task41(); break;
                        case 42: R1Task42(); break;
                        case 43: R1Task43(); break;
                        case 44: R1Task44(); break;
                        case 45: R1Task45(); break;
                        case 46: R1Task46(); break;
                        case 47: R1Task47(); break;
                        case 48: R1Task48(); break;
                        case 49: R1Task49(); break;
                        case 50: R1Task50(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;
                case 3:
                    switch (task)
                    {
                        case 51: R2Task1(); break;
                        case 52: R2Task2(); break;
                        case 53: R2Task3(); break;
                        case 54: R2Task4(); break;
                        case 55: R2Task5(); break;
                        case 56: R2Task6(); break;
                        case 57: R2Task7(); break;
                        case 58: R2Task8(); break;
                        case 59: R2Task9(); break;
                        case 60: R2Task10(); break;
                        case 61: R2Task11(); break;
                        case 62: R2Task12(); break;
                        case 63: R2Task13(); break;
                        case 64: R2Task14(); break;
                        case 65: R2Task15(); break;
                        case 66: R2Task16(); break;
                        case 67: R2Task17(); break;
                        case 68: R2Task18(); break;
                        case 69: R2Task19(); break;
                        case 70: R2Task20(); break;
                        case 71: R2Task21(); break;
                        case 72: R2Task22(); break;
                        case 73: R2Task23(); break;
                        case 74: R2Task24(); break;
                        case 75: R2Task25(); break;
                        case 76: R2Task26(); break;
                        case 77: R2Task27(); break;
                        case 78: R2Task28(); break;
                        case 79: R2Task29(); break;
                        case 80: R2Task30(); break;
                        case 81: R2Task31(); break;
                        case 82: R2Task32(); break;
                        case 83: R2Task33(); break;
                        case 84: R2Task34(); break;
                        case 85: R2Task35(); break;
                        case 86: R2Task36(); break;
                        case 87: R2Task37(); break;
                        case 88: R2Task38(); break;
                        case 89: R2Task39(); break;
                        case 90: R2Task40(); break;
                        case 91: R2Task41(); break;
                        case 92: R2Task42(); break;
                        case 93: R2Task43(); break;
                        case 94: R2Task44(); break;
                        case 95: R2Task45(); break;
                        case 96: R2Task46(); break;
                        case 97: R2Task47(); break;
                        case 98: R2Task48(); break;
                        case 99: R2Task49(); break;
                        case 100: R2Task50(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;
                case 4:
                    switch (task)
                    {
                        case 101: R3Task1(); break;
                        case 102: R3Task2(); break;
                        case 103: R3Task3(); break;
                        case 104: R3Task4(); break;
                        case 105: R3Task5(); break;
                        case 106: R3Task6(); break;
                        case 107: R3Task7(); break;
                        case 108: R3Task8(); break;
                        case 109: R3Task9(); break;
                        case 110: R3Task10(); break;
                        case 111: R3Task11(); break;
                        case 112: R3Task12(); break;
                        case 113: R3Task13(); break;
                        case 114: R3Task14(); break;
                        case 115: R3Task15(); break;
                        case 116: R3Task16(); break;
                        case 117: R3Task17(); break;
                        case 118: R3Task18(); break;
                        case 119: R3Task19(); break;
                        case 120: R3Task20(); break;
                        case 121: R3Task21(); break;
                        case 122: R3Task22(); break;
                        case 123: R3Task23(); break;
                        case 124: R3Task24(); break;
                        case 125: R3Task25(); break;
                        case 126: R3Task26(); break;
                        case 127: R3Task27(); break;
                        case 128: R3Task28(); break;
                        case 129: R3Task29(); break;
                        case 130: R3Task30(); break;
                        case 131: R3Task31(); break;
                        case 132: R3Task32(); break;
                        case 133: R3Task33(); break;
                        case 134: R3Task34(); break;
                        case 135: R3Task35(); break;
                        case 136: R3Task36(); break;
                        case 137: R3Task37(); break;
                        case 138: R3Task38(); break;
                        case 139: R3Task39(); break;
                        case 140: R3Task40(); break;
                        case 141: R3Task41(); break;
                        case 142: R3Task42(); break;
                        case 143: R3Task43(); break;
                        case 144: R3Task44(); break;
                        case 145: R3Task45(); break;
                        case 146: R3Task46(); break;
                        case 147: R3Task47(); break;
                        case 148: R3Task48(); break;
                        case 149: R3Task49(); break;
                        case 150: R3Task50(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;
                case 5:
                    switch (task)
                    {
                        case 151: R4Task1(); break;
                        case 152: R4Task2(); break;
                        case 153: R4Task3(); break;
                        case 154: R4Task4(); break;
                        case 155: R4Task5(); break;
                        case 156: R4Task6(); break;
                        case 157: R4Task7(); break;
                        case 158: R4Task8(); break;
                        case 159: R4Task9(); break;
                        case 160: R4Task10(); break;
                        case 161: R4Task11(); break;
                        case 162: R4Task12(); break;
                        case 163: R4Task13(); break;
                        case 164: R4Task14(); break;
                        case 165: R4Task15(); break;
                        case 166: R4Task16(); break;
                        case 167: R4Task17(); break;
                        case 168: R4Task18(); break;
                        case 169: R4Task19(); break;
                        case 170: R4Task20(); break;
                        case 171: R4Task21(); break;
                        case 172: R4Task22(); break;
                        case 173: R4Task23(); break;
                        case 174: R4Task24(); break;
                        case 175: R4Task25(); break;
                        case 176: R4Task26(); break;
                        case 177: R4Task27(); break;
                        case 178: R4Task28(); break;
                        case 179: R4Task29(); break;
                        case 180: R4Task30(); break;
                        case 181: R4Task31(); break;
                        case 182: R4Task32(); break;
                        case 183: R4Task33(); break;
                        case 184: R4Task34(); break;
                        case 185: R4Task35(); break;
                        case 186: R4Task36(); break;
                        case 187: R4Task37(); break;
                        case 188: R4Task38(); break;
                        case 189: R4Task39(); break;
                        case 190: R4Task40(); break;
                        case 191: R4Task41(); break;
                        case 192: R4Task42(); break;
                        case 193: R4Task43(); break;
                        case 194: R4Task44(); break;
                        case 195: R4Task45(); break;
                        case 196: R4Task46(); break;
                        case 197: R4Task47(); break;
                        case 198: R4Task48(); break;
                        case 199: R4Task49(); break;
                        case 200: R4Task50(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }

    // строка с примерами
    static void Example1()
    {
        Console.Write("Введите скорость движения (км/ч): ");
        if (!int.TryParse(Console.ReadLine(), out int speed))
        {
            Console.WriteLine("Ошибка: некорректный ввод числа.");
            return;
        }
        const int maxAllowedSpeed = 60;
        if (speed > maxAllowedSpeed)
        {
            int overspeed = speed - maxAllowedSpeed;
            Console.WriteLine($"Нарушение! Превышение на {overspeed} км/ч.");
            Console.WriteLine("Штраф: 500 рублей.");
        }
        else
        {
            Console.WriteLine("Скорость в пределах нормы. Нарушений нет.");
        }
    }
    static void Example2()
    {
        Console.Write("Введите температуру ОЖ (°C): ");
        if (!double.TryParse(Console.ReadLine(), out double temp))
        {
            Console.WriteLine("Некорректный ввод.");
            return;
        }
        if (temp < 40) Console.WriteLine("Холодный двигатель (прогрев).");
        else if (temp <= 84) Console.WriteLine("Рабочий режим до рабочей температуры.");
        else if (temp <= 105) Console.WriteLine("Оптимальная рабочая температура.");
        else Console.WriteLine("Критический перегрев! Заглушите мотор!");
    }
    static void Example3()
    {
        Console.Write("Введите сторону a: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону b: "); double b = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону c: "); double c = double.Parse(Console.ReadLine());
        bool isValidTriangle = (a + b > c) && (a + c > b) && (b + c > a);
        if (!isValidTriangle) Console.WriteLine("Треугольник с такими сторонами существовать не может.");
        else
        {
            Console.WriteLine("Треугольник существует.");
            if (a == b && b == c) Console.WriteLine("Этот треугольник — равносторонний.");
        }
    }
    static void Example4()
    {
        Console.WriteLine("=== МЕНЮ ДИАГНОСТИКИ ===");
        Console.WriteLine("1. Блок управления двигателем (ECU)");
        Console.WriteLine("2. Автоматическая трансмиссия (TCU)");
        Console.WriteLine("3. Антиблокировочная система (ABS)");
        Console.WriteLine("4. Система подушек безопасности (SRS)");
        Console.Write("Выберите пункт (1-4): ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("Запрос кодов ошибок ECU... Ошибок нет."); break;
            case 2: Console.WriteLine("Чтение параметров давления масла в TCU..."); break;
            case 3: Console.WriteLine("Опрос датчиков скорости вращения колес..."); break;
            case 4: Console.WriteLine("Проверка сопротивления пиропатронов SRS..."); break;
            default: Console.WriteLine("Ошибка: выбран несуществующий раздел меню."); break;
        }
    }

    // первый раздел
    static void R1Task1()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0) Console.WriteLine("Число положительное.");
        else Console.WriteLine("Число не положительное.");
    }
    static void R1Task2()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) Console.WriteLine("Число четное.");
        else Console.WriteLine("Число нечетное.");
    }
    static void R1Task3()
    {
        Console.Write("Введите первое число: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); int b = int.Parse(Console.ReadLine());
        if (a > b) Console.WriteLine($"Наибольшее: {a}"); else Console.WriteLine($"Наибольшее: {b}");
    }
    static void R1Task4()
    {
        Console.Write("Введите первое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); double b = double.Parse(Console.ReadLine());
        if (a < b) Console.WriteLine($"Наименьшее: {a}"); else Console.WriteLine($"Наименьшее: {b}");
    }
    static void R1Task5()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 5 == 0) Console.WriteLine("Делится на 5."); else Console.WriteLine("Не делится на 5.");
    }
    static void R1Task6()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 10 == 0) Console.WriteLine("Оканчивается нулем."); else Console.WriteLine("Не оканчивается нулем.");
    }
    static void R1Task7()
    {
        Console.Write("Введите температуру: "); double t = double.Parse(Console.ReadLine());
        if (t < 0) Console.WriteLine("На улице мороз, наденьте шапку.");
    }
    static void R1Task8()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n > 100) n -= 20; else n += 10;
        Console.WriteLine($"Результат: {n}");
    }
    static void R1Task9()
    {
        Console.Write("Введите первое число: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); int b = int.Parse(Console.ReadLine());
        if (a == b) Console.WriteLine("Числа равны."); else Console.WriteLine($"Произведение: {a * b}");
    }
    static void R1Task10()
    {
        Console.Write("Введите возраст: "); int age = int.Parse(Console.ReadLine());
        if (age >= 18) Console.WriteLine("Доступ разрешен."); else Console.WriteLine("Доступ запрещен.");
    }
    static void R1Task11()
    {
        Console.Write("Введите число: "); int n = Math.Abs(int.Parse(Console.ReadLine()));
        if (n >= 100 && n <= 999) Console.WriteLine("Да."); else Console.WriteLine("Нет.");
    }
    static void R1Task12()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 3 == 0) Console.WriteLine("Делится на 3."); else Console.WriteLine("Не делится на 3.");
    }
    static void R1Task13()
    {
        Console.Write("Введите X: "); double x = double.Parse(Console.ReadLine());
        if (x > 0) Console.WriteLine("Точка правее нуля."); else Console.WriteLine("Точка не правее нуля.");
    }
    static void R1Task14()
    {
        Console.Write("Введите баланс: "); double b = double.Parse(Console.ReadLine());
        if (b < 0) Console.WriteLine("Задолженность!");
    }
    static void R1Task15()
    {
        Console.Write("Введите пароль: "); int p = int.Parse(Console.ReadLine());
        if (p == 1234) Console.WriteLine("Вход выполнен."); else Console.WriteLine("Неверный пароль.");
    }
    static void R1Task16()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n < 0) Console.WriteLine("Отрицательное."); else Console.WriteLine("Не отрицательное.");
    }
    static void R1Task17()
    {
        Console.Write("Введите первое число: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Разность: {Math.Abs(a - b)}");
    }
    static void R1Task18()
    {
        Console.Write("Введите сумму покупки: "); double s = double.Parse(Console.ReadLine());
        if (s > 1000) Console.WriteLine($"Итоговая цена со скидкой 5%: {s * 0.95}");
        else Console.WriteLine($"Итоговая цена: {s}");
    }
    static void R1Task19()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) n /= 2; else n *= 3;
        Console.WriteLine($"Результат: {n}");
    }
    static void R1Task20()
    {
        Console.Write("Введите скорость: "); double v = double.Parse(Console.ReadLine());
        if (v > 90) Console.WriteLine("Нарушение!");
    }
    static void R1Task21()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n == 0) Console.WriteLine("Число равно нулю."); else Console.WriteLine("Число не равно нулю.");
    }
    static void R1Task22()
    {
        Console.Write("Введите первое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); double b = double.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < 0.001) Console.WriteLine("Равны с точностью 0.001.");
        else Console.WriteLine("Не равны с точностью 0.001.");
    }
    static void R1Task23()
    {
        Console.Write("Введите A: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Введите B: "); int b = int.Parse(Console.ReadLine());
        if (b != 0 && a % b == 0) Console.WriteLine("Делится без остатка.");
        else Console.WriteLine("Не делится без остатка.");
    }
    static void R1Task24()
    {
        Console.Write("Введите первый угол: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второй угол: "); double b = double.Parse(Console.ReadLine());
        if (a + b < 180) Console.WriteLine("Треугольник существует.");
        else Console.WriteLine("Треугольник не существует.");
    }
    static void R1Task25()
    {
        Console.Write("Введите радиус круга: "); double r = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону квадрата: "); double s = double.Parse(Console.ReadLine());
        double circleArea = Math.PI * r * r, squareArea = s * s;
        if (circleArea > squareArea) Console.WriteLine("Площадь круга больше.");
        else Console.WriteLine("Площадь квадрата больше.");
    }
    static void R1Task26()
    {
        Console.Write("Введите первое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); double b = double.Parse(Console.ReadLine());
        double bigger = Math.Max(a, b), smaller = Math.Min(a, b);
        if (smaller == 0) Console.WriteLine("Деление на ноль невозможно.");
        else Console.WriteLine($"Частное: {bigger / smaller}");
    }
    static void R1Task27()
    {
        Console.Write("Введите число: "); int n = Math.Abs(int.Parse(Console.ReadLine()));
        if (n % 10 == 7) Console.WriteLine("Оканчивается на 7."); else Console.WriteLine("Не оканчивается на 7.");
    }
    static void R1Task28()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 2 != 0 && n > 0) Console.WriteLine("Да."); else Console.WriteLine("Нет.");
    }
    static void R1Task29()
    {
        Console.Write("Введите свободное место (ГБ): "); double s = double.Parse(Console.ReadLine());
        if (s < 5) Console.WriteLine("Мало свободного места!");
    }
    static void R1Task30()
    {
        Console.Write("Введите оценку: "); int g = int.Parse(Console.ReadLine());
        if (g == 4 || g == 5) Console.WriteLine("Молодец."); else Console.WriteLine("Нужно подтянуться.");
    }
    static void R1Task31()
    {
        Console.Write("Введите первый символ: "); char a = Console.ReadLine()[0];
        Console.Write("Введите второй символ: "); char b = Console.ReadLine()[0];
        if (a == b) Console.WriteLine("Символы совпадают."); else Console.WriteLine("Символы не совпадают.");
    }
    static void R1Task32()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0 && n % 7 == 0) Console.WriteLine("Кратно 14."); else Console.WriteLine("Не кратно 14.");
    }
    static void R1Task33()
    {
        Console.Write("Введите массу груза (т): "); double m = double.Parse(Console.ReadLine());
        if (m > 3.5) Console.WriteLine("Перегруз!");
    }
    static void R1Task34()
    {
        Console.Write("Введите час (0-23): "); int h = int.Parse(Console.ReadLine());
        if (h >= 6 && h <= 12) Console.WriteLine("Доброе утро.");
    }
    static void R1Task35()
    {
        Console.Write("Введите рост (см): "); int r = int.Parse(Console.ReadLine());
        if (r > 200) Console.WriteLine("Очень высокий.");
    }
    static void R1Task36()
    {
        Console.Write("Введите двузначное число: "); int n = int.Parse(Console.ReadLine());
        int d1 = n / 10, d2 = n % 10;
        if (d1 > d2) Console.WriteLine("Первая цифра больше.");
        else if (d2 > d1) Console.WriteLine("Вторая цифра больше.");
        else Console.WriteLine("Цифры равны.");
    }
    static void R1Task37()
    {
        Console.Write("Введите цену: "); double p = double.Parse(Console.ReadLine());
        if (p == 0) Console.WriteLine("Акция!");
    }
    static void R1Task38()
    {
        Console.Write("Введите двузначное число: "); int n = int.Parse(Console.ReadLine());
        if (n / 10 == n % 10) Console.WriteLine("Цифры одинаковые."); else Console.WriteLine("Цифры разные.");
    }
    static void R1Task39()
    {
        Console.Write("Введите громкость (0-100): "); int v = int.Parse(Console.ReadLine());
        if (v > 80) Console.WriteLine("Слишком громко для слуха.");
    }
    static void R1Task40()
    {
        Console.Write("Введите первое число: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: "); int b = int.Parse(Console.ReadLine());
        if ((a + b) % 2 == 0) Console.WriteLine($"Сумма: {a + b}");
        else Console.WriteLine($"Разность: {a - b}");
    }
    static void R1Task41()
    {
        Console.Write("Введите количество страниц: "); int p = int.Parse(Console.ReadLine());
        if (p > 100) Console.WriteLine("Включена двухсторонняя печать.");
    }
    static void R1Task42()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        int root = (int)Math.Sqrt(n);
        if (root * root == n) Console.WriteLine("Полный квадрат."); else Console.WriteLine("Не полный квадрат.");
    }
    static void R1Task43()
    {
        Console.Write("Введите давление: "); double p = double.Parse(Console.ReadLine());
        if (p < 740) Console.WriteLine("Пониженное давление.");
    }
    static void R1Task44()
    {
        Console.Write("Голы команды А: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Голы команды Б: "); int b = int.Parse(Console.ReadLine());
        if (a > b) Console.WriteLine("Победила А.");
        else if (b > a) Console.WriteLine("Победила Б.");
        else Console.WriteLine("Ничья.");
    }
    static void R1Task45()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n < 0) n = -n;
        Console.WriteLine($"Модуль: {n}");
    }
    static void R1Task46()
    {
        Console.Write("Введите сахар: "); double s = double.Parse(Console.ReadLine());
        if (s > 6.1) Console.WriteLine("Выше нормы.");
    }
    static void R1Task47()
    {
        Console.Write("Введите средства: "); double m = double.Parse(Console.ReadLine());
        if (m >= 35) Console.WriteLine("Хватает."); else Console.WriteLine("Не хватает.");
    }
    static void R1Task48()
    {
        Console.Write("Введите этаж: "); int f = int.Parse(Console.ReadLine());
        if (f > 10) Console.WriteLine("Высотный этаж.");
    }
    static void R1Task49()
    {
        Console.Write("Введите первое слово: "); string a = Console.ReadLine();
        Console.Write("Введите второе слово: "); string b = Console.ReadLine();
        if (a.Length == b.Length) Console.WriteLine("Одинаковы по длине.");
        else Console.WriteLine("Разные по длине.");
    }
    static void R1Task50()
    {
        Console.Write("Введите число: "); int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) Console.WriteLine("Число четное."); else Console.WriteLine("Число нечетное.");
    }

    // второй раздел
    static void R2Task1()
    {
        Console.Write("Балл: "); int b = int.Parse(Console.ReadLine());
        if (b >= 90) Console.WriteLine("A");
        else if (b >= 80) Console.WriteLine("B");
        else if (b >= 70) Console.WriteLine("C");
        else if (b >= 60) Console.WriteLine("D");
        else Console.WriteLine("F");
    }
    static void R2Task2()
    {
        Console.Write("Возраст: "); int a = int.Parse(Console.ReadLine());
        if (a <= 12) Console.WriteLine("Ребенок");
        else if (a <= 17) Console.WriteLine("Подросток");
        else if (a <= 64) Console.WriteLine("Взрослый");
        else Console.WriteLine("Пожилой");
    }
    static void R2Task3()
    {
        Console.Write("Температура: "); double t = double.Parse(Console.ReadLine());
        if (t <= 0) Console.WriteLine("Лед");
        else if (t < 100) Console.WriteLine("Жидкость");
        else Console.WriteLine("Пар");
    }
    static void R2Task4()
    {
        Console.Write("Заряд: "); int z = int.Parse(Console.ReadLine());
        if (z < 10) Console.WriteLine("Критический");
        else if (z <= 20) Console.WriteLine("Низкий");
        else if (z <= 80) Console.WriteLine("Нормальный");
        else Console.WriteLine("Полный");
    }
    static void R2Task5()
    {
        Console.Write("RPM: "); int r = int.Parse(Console.ReadLine());
        if (r == 0) Console.WriteLine("Заглушен");
        else if (r <= 900) Console.WriteLine("Холостой ход");
        else if (r <= 3500) Console.WriteLine("Рабочий");
        else Console.WriteLine("Красная зона");
    }
    static void R2Task6()
    {
        Console.Write("Доход: "); double d = double.Parse(Console.ReadLine());
        double tax = d <= 2_400_000 ? d * 0.13 : d <= 5_000_000 ? d * 0.15 : d * 0.18;
        Console.WriteLine($"Налог: {tax}");
    }
    static void R2Task7()
    {
        Console.Write("X: "); double x = double.Parse(Console.ReadLine());
        if (x == 0) Console.WriteLine("На нуле");
        else if (x > 0) Console.WriteLine("Положительная полуось");
        else Console.WriteLine("Отрицательная полуось");
    }
    static void R2Task8()
    {
        Console.Write("ИМТ: "); double b = double.Parse(Console.ReadLine());
        if (b < 18.5) Console.WriteLine("Дефицит веса");
        else if (b <= 24.9) Console.WriteLine("Норма");
        else if (b <= 29.9) Console.WriteLine("Избыток");
        else Console.WriteLine("Ожирение");
    }
    static void R2Task9()
    {
        Console.Write("Ветер: "); double v = double.Parse(Console.ReadLine());
        if (v < 0.2) Console.WriteLine("Штиль");
        else if (v <= 5) Console.WriteLine("Легкий ветерок");
        else if (v <= 14) Console.WriteLine("Умеренный");
        else if (v <= 24) Console.WriteLine("Шторм");
        else Console.WriteLine("Ураган");
    }
    static void R2Task10()
    {
        Console.Write("Стаж: "); int s = int.Parse(Console.ReadLine());
        if (s < 1) Console.WriteLine("0%");
        else if (s <= 5) Console.WriteLine("5%");
        else if (s <= 10) Console.WriteLine("10%");
        else Console.WriteLine("15%");
    }
    static void R2Task11()
    {
        Console.Write("Час: "); int h = int.Parse(Console.ReadLine());
        if (h <= 5) Console.WriteLine("Ночь");
        else if (h <= 11) Console.WriteLine("Утро");
        else if (h <= 17) Console.WriteLine("День");
        else Console.WriteLine("Вечер");
    }
    static void R2Task12()
    {
        Console.Write("Толщина льда: "); double t = double.Parse(Console.ReadLine());
        if (t < 7) Console.WriteLine("Выход запрещен");
        else if (t <= 12) Console.WriteLine("Одиночный пешеход");
        else if (t <= 20) Console.WriteLine("Группа людей");
        else Console.WriteLine("Транспорт");
    }
    static void R2Task13()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        int m = a;
        if (b > m) m = b; if (c > m) m = c;
        Console.WriteLine($"Максимум: {m}");
    }
    static void R2Task14()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        int m = a;
        if (b < m) m = b; if (c < m) m = c;
        Console.WriteLine($"Минимум: {m}");
    }
    static void R2Task15()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        int cnt = (a > 0 ? 1 : 0) + (b > 0 ? 1 : 0) + (c > 0 ? 1 : 0);
        Console.WriteLine($"Положительных: {cnt}");
    }
    static void R2Task16()
    {
        Console.Write("Средний балл: "); double s = double.Parse(Console.ReadLine());
        if (s < 4.5) Console.WriteLine("Без отличия");
        else if (s < 4.75) Console.WriteLine("Претендент на красный диплом");
        else Console.WriteLine("Красный диплом");
    }
    static void R2Task17()
    {
        Console.Write("Давление: "); int d = int.Parse(Console.ReadLine());
        if (d < 90) Console.WriteLine("Гипотония");
        else if (d <= 120) Console.WriteLine("Норма");
        else if (d <= 139) Console.WriteLine("Предгипертензия");
        else Console.WriteLine("Гипертензия");
    }
    static void R2Task18()
    {
        Console.Write("Эло: "); int e = int.Parse(Console.ReadLine());
        if (e < 1400) Console.WriteLine("Любитель");
        else if (e <= 1999) Console.WriteLine("Разрядник");
        else if (e <= 2399) Console.WriteLine("Мастер");
        else Console.WriteLine("Гроссмейстер");
    }
    static void R2Task19()
    {
        Console.Write("Число: "); int n = Math.Abs(int.Parse(Console.ReadLine()));
        if (n < 10) Console.WriteLine("Однозначное");
        else if (n < 100) Console.WriteLine("Двузначное");
        else if (n < 1000) Console.WriteLine("Трехзначное");
        else Console.WriteLine("Более трехзначного");
    }
    static void R2Task20()
    {
        Console.Write("Км: "); double km = double.Parse(Console.ReadLine());
        double price;
        if (km <= 5) price = 200;
        else if (km <= 15) price = 200 + (km - 5) * 25;
        else price = 200 + 250 + (km - 15) * 20;
        Console.WriteLine($"Стоимость: {price}");
    }
    static void R2Task21()
    {
        Console.Write("Осадки: "); double o = double.Parse(Console.ReadLine());
        if (o == 0) Console.WriteLine("Без осадков");
        else if (o <= 4) Console.WriteLine("Слабый дождь");
        else if (o <= 15) Console.WriteLine("Умеренный");
        else Console.WriteLine("Сильный ливень");
    }
    static void R2Task22()
    {
        Console.Write("План: "); double p = double.Parse(Console.ReadLine());
        if (p < 70) Console.WriteLine("План сорван");
        else if (p < 100) Console.WriteLine("Удовлетворительно");
        else if (p < 120) Console.WriteLine("Выполнен");
        else Console.WriteLine("Перевыполнен");
    }
    static void R2Task23()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]), t;
        if (a > b) { t = a; a = b; b = t; }
        if (b > c) { t = b; b = c; c = t; }
        if (a > b) { t = a; a = b; b = t; }
        Console.WriteLine($"{a} {b} {c}");
    }
    static void R2Task24()
    {
        Console.Write("X: "); double x = double.Parse(Console.ReadLine());
        double f = x > 0 ? x * x : x == 0 ? 0 : -x;
        Console.WriteLine($"f(x) = {f}");
    }
    static void R2Task25()
    {
        Console.Write("Октановое число: "); int o = int.Parse(Console.ReadLine());
        if (o < 92) Console.WriteLine("Несоответствие стандарту");
        else if (o == 92) Console.WriteLine("АИ-92");
        else if (o == 95) Console.WriteLine("АИ-95");
        else if (o <= 100) Console.WriteLine("АИ-98/100");
        else Console.WriteLine("Спорт/авиатопливо");
    }
    static void R2Task26()
    {
        Console.Write("Сумма покупок: "); double s = double.Parse(Console.ReadLine());
        double cb = s <= 10000 ? s * 0.01 : s <= 50000 ? s * 0.03 : s * 0.05;
        Console.WriteLine($"Кешбэк: {cb}");
    }
    static void R2Task27()
    {
        Console.Write("Глубина: "); double d = double.Parse(Console.ReadLine());
        if (d < 40) Console.WriteLine("Рекреационная");
        else if (d <= 100) Console.WriteLine("Техническая");
        else Console.WriteLine("Глубоководная");
    }
    static void R2Task28()
    {
        Console.Write("Баллы: "); int b = int.Parse(Console.ReadLine());
        if (b >= 1 && b <= 5) Console.WriteLine("Предупреждение");
        else if (b <= 10) Console.WriteLine("Временное ограничение");
        else Console.WriteLine("Лишение прав");
    }
    static void R2Task29()
    {
        Console.Write("pH: "); double p = double.Parse(Console.ReadLine());
        if (p < 6.0) Console.WriteLine("Кислая");
        else if (p <= 7.2) Console.WriteLine("Нейтральная");
        else Console.WriteLine("Щелочная");
    }
    static void R2Task30()
    {
        Console.Write("Очки: "); int o = int.Parse(Console.ReadLine());
        if (o >= 5000) Console.WriteLine("Золотая");
        else if (o >= 2500) Console.WriteLine("Серебряная");
        else if (o >= 1000) Console.WriteLine("Бронзовая");
        else Console.WriteLine("Без медали");
    }
    static void R2Task31()
    {
        Console.Write("Градусы: "); double g = double.Parse(Console.ReadLine());
        if (g == 0) Console.WriteLine("Безалкогольный");
        else if (g <= 8) Console.WriteLine("Слабоалкогольный");
        else if (g <= 25) Console.WriteLine("Среднеалкогольный");
        else Console.WriteLine("Крепкий");
    }
    static void R2Task32()
    {
        Console.Write("дБ: "); int d = int.Parse(Console.ReadLine());
        if (d < 40) Console.WriteLine("Тихо");
        else if (d <= 60) Console.WriteLine("Норма");
        else if (d <= 80) Console.WriteLine("Шумно");
        else Console.WriteLine("Вредно для здоровья");
    }
    static void R2Task33()
    {
        Console.Write("Вес: "); double w = double.Parse(Console.ReadLine());
        if (w < 2) Console.WriteLine("Мелкий пакет");
        else if (w <= 10) Console.WriteLine("Стандартная");
        else if (w <= 31.5) Console.WriteLine("Тяжеловесная");
        else Console.WriteLine("Крупногабарит");
    }
    static void R2Task34()
    {
        Console.Write("Комнат: "); int k = int.Parse(Console.ReadLine());
        if (k == 1) Console.WriteLine("Студия/однокомнатная");
        else if (k == 2) Console.WriteLine("Двухкомнатная");
        else if (k == 3) Console.WriteLine("Трехкомнатная");
        else Console.WriteLine("Многокомнатная");
    }
    static void R2Task35()
    {
        Console.Write("Заряд: "); int z = int.Parse(Console.ReadLine());
        if (z <= 25) Console.WriteLine("1 LED");
        else if (z <= 50) Console.WriteLine("2 LED");
        else if (z <= 75) Console.WriteLine("3 LED");
        else Console.WriteLine("4 LED");
    }
    static void R2Task36()
    {
        Console.Write("Выслуга лет: "); int v = int.Parse(Console.ReadLine());
        Console.WriteLine($"Надбавка: {v * 2}%");
    }
    static void R2Task37()
    {
        Console.Write("Пинг: "); int p = int.Parse(Console.ReadLine());
        if (p < 20) Console.WriteLine("Идеальный");
        else if (p <= 60) Console.WriteLine("Хороший");
        else if (p <= 120) Console.WriteLine("Посредственный");
        else Console.WriteLine("Плохой");
    }
    static void R2Task38()
    {
        Console.Write("CO2: "); int c = int.Parse(Console.ReadLine());
        if (c < 800) Console.WriteLine("Норма");
        else if (c <= 1200) Console.WriteLine("Душно");
        else Console.WriteLine("Проветрить немедленно");
    }
    static void R2Task39()
    {
        Console.Write("Шаги: "); int s = int.Parse(Console.ReadLine());
        if (s < 5000) Console.WriteLine("Гиподинамия");
        else if (s < 10000) Console.WriteLine("Норма");
        else if (s < 15000) Console.WriteLine("Активный день");
        else Console.WriteLine("Рекорд");
    }
    static void R2Task40()
    {
        Console.Write("Диаметр: "); int d = int.Parse(Console.ReadLine());
        if (d <= 14) Console.WriteLine("Малолитражки");
        else if (d <= 16) Console.WriteLine("Компактные авто");
        else if (d <= 19) Console.WriteLine("Кроссоверы/бизнес");
        else Console.WriteLine("Внедорожники/спорт");
    }
    static void R2Task41()
    {
        Console.Write("Влажность: "); int v = int.Parse(Console.ReadLine());
        if (v < 30) Console.WriteLine("Сухой воздух");
        else if (v <= 60) Console.WriteLine("Комфорт");
        else Console.WriteLine("Повышенная влажность");
    }
    static void R2Task42()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        if (a == b && b == c) Console.WriteLine("Все три равны");
        else if (a == b || b == c || a == c) Console.WriteLine("Два равны");
        else Console.WriteLine("Все разные");
    }
    static void R2Task43()
    {
        Console.Write("Четверть: "); int q = int.Parse(Console.ReadLine());
        switch (q)
        {
            case 1: Console.WriteLine("X>0, Y>0"); break;
            case 2: Console.WriteLine("X<0, Y>0"); break;
            case 3: Console.WriteLine("X<0, Y<0"); break;
            case 4: Console.WriteLine("X>0, Y<0"); break;
            default: Console.WriteLine("Неверная четверть"); break;
        }
    }
    static void R2Task44()
    {
        Console.Write("Температура: "); int t = int.Parse(Console.ReadLine());
        if (t < 45) Console.WriteLine("Холодный");
        else if (t <= 75) Console.WriteLine("Нормальная нагрузка");
        else Console.WriteLine("Троттлинг/перегрев");
    }
    static void R2Task45()
    {
        Console.Write("Дней: "); int d = int.Parse(Console.ReadLine());
        if (d <= 2) Console.WriteLine("Срочно употребить");
        else if (d <= 30) Console.WriteLine("Нормально");
        else Console.WriteLine("Длительное хранение");
    }
    static void R2Task46()
    {
        Console.Write("Сумма и срок (лет): "); var p = Console.ReadLine().Split();
        double s = double.Parse(p[0]); int y = int.Parse(p[1]);
        double rate = y <= 1 ? 0.15 : y <= 3 ? 0.12 : 0.09;
        Console.WriteLine($"Ставка: {rate * 100}%");
    }
    static void R2Task47()
    {
        Console.Write("Гц: "); int h = int.Parse(Console.ReadLine());
        if (h < 120) Console.WriteLine("Офис");
        else if (h < 165) Console.WriteLine("Базовый игровой");
        else Console.WriteLine("Киберспорт");
    }
    static void R2Task48()
    {
        Console.Write("Расход: "); double r = double.Parse(Console.ReadLine());
        if (r < 6) Console.WriteLine("Экономичный");
        else if (r <= 10) Console.WriteLine("Средний");
        else Console.WriteLine("Прожорливый");
    }
    static void R2Task49()
    {
        Console.Write("Страниц: "); int p = int.Parse(Console.ReadLine());
        if (p < 48) Console.WriteLine("Брошюра");
        else if (p <= 150) Console.WriteLine("Повесть");
        else if (p <= 600) Console.WriteLine("Роман");
        else Console.WriteLine("Фолиант");
    }
    static void R2Task50()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        bool ok = (n >= 0 && n <= 10) || (n >= 20 && n <= 30) || (n >= 50 && n <= 100);
        Console.WriteLine(ok ? "Попадает" : "Не попадает");
    }

    // третий раздле
    static void R3Task1()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n >= 10 && n <= 50 ? "Принадлежит" : "Не принадлежит");
    }
    static void R3Task2()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n > 0 && n % 2 == 0 ? "Да" : "Нет");
    }
    static void R3Task3()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n < -10 || n > 10 ? "Вне диапазона" : "В диапазоне");
    }
    static void R3Task4()
    {
        Console.Write("Логин пароль: "); var p = Console.ReadLine().Split();
        Console.WriteLine(p[0] == "admin" && p[1] == "secret" ? "Успех" : "Отказ");
    }
    static void R3Task5()
    {
        Console.Write("Год: "); int y = int.Parse(Console.ReadLine());
        Console.WriteLine((y % 4 == 0 && y % 100 != 0) || y % 400 == 0 ? "Високосный" : "Не високосный");
    }
    static void R3Task6()
    {
        Console.Write("X Y: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        Console.WriteLine(x > 0 && y > 0 ? "I четверть" : "Не I");
    }
    static void R3Task7()
    {
        Console.Write("X Y: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        Console.WriteLine(x < 0 && y > 0 ? "II четверть" : "Не II");
    }
    static void R3Task8()
    {
        Console.Write("X Y: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        Console.WriteLine(x < 0 && y < 0 ? "III четверть" : "Не III");
    }
    static void R3Task9()
    {
        Console.Write("X Y: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        Console.WriteLine(x > 0 && y < 0 ? "IV четверть" : "Не IV");
    }
    static void R3Task10()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        double a = double.Parse(p[0]), b = double.Parse(p[1]), c = double.Parse(p[2]);
        bool ok = a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
        Console.WriteLine(ok ? "Прямоугольный" : "Не прямоугольный");
    }
    static void R3Task11()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        double a = double.Parse(p[0]), b = double.Parse(p[1]), c = double.Parse(p[2]);
        Console.WriteLine(a == b || b == c || a == c ? "Равнобедренный" : "Нет");
    }
    static void R3Task12()
    {
        Console.Write("Возраст стаж: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), s = int.Parse(p[1]);
        Console.WriteLine(a >= 23 && s >= 3 ? "Разрешено" : "Запрещено");
    }
    static void R3Task13()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 3 == 0 && n % 5 == 0 ? "Делится на 15" : "Нет");
    }
    static void R3Task14()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n >= 100 && n <= 999 && n % 10 == 5 ? "Да" : "Нет");
    }
    static void R3Task15()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        Console.WriteLine(a < b && b < c ? "По возрастанию" : "Нет");
    }
    static void R3Task16()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        Console.WriteLine(a % 2 == 0 || b % 2 == 0 || c % 2 == 0 ? "Есть четное" : "Нет");
    }
    static void R3Task17()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        int z = (a == 0 ? 1 : 0) + (b == 0 ? 1 : 0) + (c == 0 ? 1 : 0);
        Console.WriteLine(z == 1 ? "Ровно один ноль" : "Не ровно один");
    }
    static void R3Task18()
    {
        Console.Write("Температура влажность: "); var p = Console.ReadLine().Split();
        double t = double.Parse(p[0]), h = double.Parse(p[1]);
        if (t <= 0 && h > 85) Console.WriteLine("Гололедица");
    }
    static void R3Task19()
    {
        Console.Write("X Y R: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]), r = double.Parse(p[2]);
        Console.WriteLine(x * x + y * y <= r * r ? "Внутри" : "Снаружи");
    }
    static void R3Task20()
    {
        Console.Write("X Y X1 Y1 X2 Y2: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        double x1 = double.Parse(p[2]), y1 = double.Parse(p[3]);
        double x2 = double.Parse(p[4]), y2 = double.Parse(p[5]);
        bool ok = x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2) &&
                  y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2);
        Console.WriteLine(ok ? "Внутри" : "Снаружи");
    }
    static void R3Task21()
    {
        Console.Write("День месяц: "); var p = Console.ReadLine().Split();
        int d = int.Parse(p[0]), m = int.Parse(p[1]);
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        bool ok = m >= 1 && m <= 12 && d >= 1 && d <= days[m - 1];
        Console.WriteLine(ok ? "Корректна" : "Некорректна");
    }
    static void R3Task22()
    {
        Console.Write("Месяц: "); int m = int.Parse(Console.ReadLine());
        Console.WriteLine(m == 12 || m == 1 || m == 2 ? "Зима" : "Не зима");
    }
    static void R3Task23()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        int s1 = n / 1000 + n / 100 % 10;
        int s2 = n / 10 % 10 + n % 10;
        Console.WriteLine(s1 == s2 ? "Счастливый" : "Не счастливый");
    }
    static void R3Task24()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]), c = int.Parse(p[2]);
        Console.WriteLine(a == -b || a == -c || b == -c ? "Есть пара" : "Нет пары");
    }
    static void R3Task25()
    {
        Console.Write("Датчик1 датчик2 тумблер: "); var p = Console.ReadLine().Split();
        bool d1 = bool.Parse(p[0]), d2 = bool.Parse(p[1]), t = bool.Parse(p[2]);
        Console.WriteLine((d1 || d2) && t ? "Тревога" : "Спокойно");
    }
    static void R3Task26()
    {
        Console.Write("A B X: "); var p = Console.ReadLine().Split();
        double a = double.Parse(p[0]), b = double.Parse(p[1]), x = double.Parse(p[2]);
        double lo = Math.Min(a, b), hi = Math.Max(a, b);
        Console.WriteLine(x > lo && x < hi ? "Между" : "Не между");
    }
    static void R3Task27()
    {
        Console.Write("A B: "); var p = Console.ReadLine().Split();
        int a = int.Parse(p[0]), b = int.Parse(p[1]);
        Console.WriteLine((a > 0 && b > 0) || (a < 0 && b < 0) ? "Одинаковый знак" : "Разный знак");
    }
    static void R3Task28()
    {
        Console.Write("x1 y1 x2 y2: "); var p = Console.ReadLine().Split();
        int x1 = int.Parse(p[0]), y1 = int.Parse(p[1]);
        int x2 = int.Parse(p[2]), y2 = int.Parse(p[3]);
        Console.WriteLine(x1 == x2 || y1 == y2 ? "Ладья угрожает" : "Не угрожает");
    }
    static void R3Task29()
    {
        Console.Write("x1 y1 x2 y2: "); var p = Console.ReadLine().Split();
        int x1 = int.Parse(p[0]), y1 = int.Parse(p[1]);
        int x2 = int.Parse(p[2]), y2 = int.Parse(p[3]);
        Console.WriteLine(Math.Abs(x1 - x2) == Math.Abs(y1 - y2) ? "Слон угрожает" : "Не угрожает");
    }
    static void R3Task30()
    {
        Console.Write("x1 y1 x2 y2: "); var p = Console.ReadLine().Split();
        int x1 = int.Parse(p[0]), y1 = int.Parse(p[1]);
        int x2 = int.Parse(p[2]), y2 = int.Parse(p[3]);
        bool rook = x1 == x2 || y1 == y2;
        bool bishop = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        Console.WriteLine(rook || bishop ? "Ферзь угрожает" : "Не угрожает");
    }
    static void R3Task31()
    {
        Console.Write("x1 y1 x2 y2: "); var p = Console.ReadLine().Split();
        int x1 = int.Parse(p[0]), y1 = int.Parse(p[1]);
        int x2 = int.Parse(p[2]), y2 = int.Parse(p[3]);
        int dx = Math.Abs(x1 - x2), dy = Math.Abs(y1 - y2);
        Console.WriteLine((dx == 1 && dy == 2) || (dx == 2 && dy == 1) ? "Конь может" : "Не может");
    }
    static void R3Task32()
    {
        Console.Write("x1 y1 x2 y2: "); var p = Console.ReadLine().Split();
        int x1 = int.Parse(p[0]), y1 = int.Parse(p[1]);
        int x2 = int.Parse(p[2]), y2 = int.Parse(p[3]);
        Console.WriteLine((x1 + y1) % 2 == (x2 + y2) % 2 ? "Одинаковый цвет" : "Разный цвет");
    }
    static void R3Task33()
    {
        Console.Write("Рост вес: "); var p = Console.ReadLine().Split();
        int h = int.Parse(p[0]), w = int.Parse(p[1]);
        Console.WriteLine(h >= 160 && h <= 190 && w >= 50 && w <= 90 ? "Годен" : "Не годен");
    }
    static void R3Task34()
    {
        Console.Write("N: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 && n >= 10 && n <= 99 ? "Да" : "Нет");
    }
    static void R3Task35()
    {
        Console.Write("N: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 != 0 && n >= 100 && n <= 999 ? "Да" : "Нет");
    }
    static void R3Task36()
    {
        Console.Write("Мат инф: "); var p = Console.ReadLine().Split();
        int m = int.Parse(p[0]), i = int.Parse(p[1]);
        Console.WriteLine(m + i >= 150 && m >= 50 && i >= 50 ? "Зачислен" : "Не зачислен");
    }
    static void R3Task37()
    {
        Console.Write("X Y R1 R2: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        double r1 = double.Parse(p[2]), r2 = double.Parse(p[3]);
        double d = x * x + y * y;
        Console.WriteLine(d >= r1 * r1 && d <= r2 * r2 ? "В кольце" : "Вне кольца");
    }
    static void R3Task38()
    {
        Console.Write("Билет(true/false) багаж(true/false): "); var p = Console.ReadLine().Split();
        bool b = bool.Parse(p[0]), l = bool.Parse(p[1]);
        Console.WriteLine(b && l ? "Доплата не нужна" : "Нужна доплата");
    }
    static void R3Task39()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n / 1000 == n % 10 && n / 100 % 10 == n / 10 % 10 ? "Палиндром" : "Не палиндром");
    }
    static void R3Task40()
    {
        Console.Write("Напряжение частота: "); var p = Console.ReadLine().Split();
        double u = double.Parse(p[0]), f = double.Parse(p[1]);
        bool ok = Math.Abs(u - 220) <= 22 && Math.Abs(f - 50) <= 1;
        Console.WriteLine(ok ? "Стабильна" : "Нестабильна"); 
    }
    static void R3Task41()
    {
        Console.Write("Права страховка трезвость: "); var p = Console.ReadLine().Split();
        bool a = bool.Parse(p[0]), b = bool.Parse(p[1]), c = bool.Parse(p[2]);
        Console.WriteLine(a && b && c ? "Разрешен" : "Запрещен");
    }
    static void R3Task42()
    {
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        bool div4 = n % 4 == 0, div7 = n % 7 == 0, div28 = n % 28 == 0;
        Console.WriteLine((div4 || div7) && !div28 ? "Да" : "Нет");
    }
    static void R3Task43()
    {
        Console.Write("Месяц температура: "); var p = Console.ReadLine().Split();
        int m = int.Parse(p[0]); double t = double.Parse(p[1]);
        if ((m == 6 || m == 7 || m == 8) && t < 0) Console.WriteLine("Аномалия!");
    }
    static void R3Task44()
    {
        Console.Write("A B C (true/false): "); var p = Console.ReadLine().Split();
        bool a = bool.Parse(p[0]), b = bool.Parse(p[1]), c = bool.Parse(p[2]);
        int cnt = (a ? 1 : 0) + (b ? 1 : 0) + (c ? 1 : 0);
        Console.WriteLine(cnt >= 2 ? "Истина" : "Ложь");
    }
    static void R3Task45()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        double a = double.Parse(p[0]), b = double.Parse(p[1]), c = double.Parse(p[2]);
        double max = Math.Max(a, Math.Max(b, c));
        bool ok = a + b > c && a + c > b && b + c > a && max * max > (a * a + b * b + c * c - max * max);
        Console.WriteLine(ok ? "Тупоугольный" : "Не тупоугольный");
    }
    static void R3Task46()
    {
        Console.Write("A B C: "); var p = Console.ReadLine().Split();
        double a = double.Parse(p[0]), b = double.Parse(p[1]), c = double.Parse(p[2]);
        double max = Math.Max(a, Math.Max(b, c));
        bool ok = a + b > c && a + c > b && b + c > a && max * max < (a * a + b * b + c * c - max * max);
        Console.WriteLine(ok ? "Остроугольный" : "Не остроугольный");
    }
    static void R3Task47()
    {
        Console.Write("Часы минуты: "); var p = Console.ReadLine().Split();
        int h = int.Parse(p[0]), m = int.Parse(p[1]);
        int t = h * 60 + m;
        Console.WriteLine(t >= 13 * 60 && t <= 15 * 60 ? "Тихий час" : "Не тихий час");
    }
    static void R3Task48()
    {
        Console.Write("Трехзначное: "); int n = int.Parse(Console.ReadLine());
        int a = n / 100, b = n / 10 % 10, c = n % 10;
        Console.WriteLine(a != b && b != c && a != c ? "Все разные" : "Есть совпадения");
    }
    static void R3Task49()
    {
        Console.Write("Кнопка1 кнопка2: "); var p = Console.ReadLine().Split();
        bool k1 = bool.Parse(p[0]), k2 = bool.Parse(p[1]);
        Console.WriteLine(k1 && k2 ? "Станок запущен" : "Ожидание");
    }
    static void R3Task50()
    {
        Console.Write("X Y: "); var p = Console.ReadLine().Split();
        double x = double.Parse(p[0]), y = double.Parse(p[1]);
        Console.WriteLine(y < 2 * x + 1 && y > x * x ? "В области" : "Вне области");
    }

    // четвёртый раздел
    static void R4Task1()
    {
        Console.Write("День: "); int d = int.Parse(Console.ReadLine());
        switch (d)
        {
            case 1: Console.WriteLine("Понедельник"); break;
            case 2: Console.WriteLine("Вторник"); break;
            case 3: Console.WriteLine("Среда"); break;
            case 4: Console.WriteLine("Четверг"); break;
            case 5: Console.WriteLine("Пятница"); break;
            case 6: Console.WriteLine("Суббота"); break;
            case 7: Console.WriteLine("Воскресенье"); break;
            default: Console.WriteLine("Неверный день."); break;
        }
    }
    static void R4Task2()
    {
        Console.Write("День: "); int d = int.Parse(Console.ReadLine());
        switch (d)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Будни"); break;
            case 6:
            case 7:
                Console.WriteLine("Выходной"); break;
            default: Console.WriteLine("Неверный день."); break;
        }
    }
    static void R4Task3()
    {
        Console.Write("Месяц: "); int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1: Console.WriteLine("Январь"); break;
            case 2: Console.WriteLine("Февраль"); break;
            case 3: Console.WriteLine("Март"); break;
            case 4: Console.WriteLine("Апрель"); break;
            case 5: Console.WriteLine("Май"); break;
            case 6: Console.WriteLine("Июнь"); break;
            case 7: Console.WriteLine("Июль"); break;
            case 8: Console.WriteLine("Август"); break;
            case 9: Console.WriteLine("Сентябрь"); break;
            case 10: Console.WriteLine("Октябрь"); break;
            case 11: Console.WriteLine("Ноябрь"); break;
            case 12: Console.WriteLine("Декабрь"); break;
            default: Console.WriteLine("Неверный месяц."); break;
        }
    }
    static void R4Task4()
    {
        Console.Write("Месяц: "); int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("31 день"); break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30 дней"); break;
            case 2:
                Console.WriteLine("28 дней (невисокосный год)"); break;
            default: Console.WriteLine("Неверный месяц."); break;
        }
    }
    static void R4Task5()
    {
        Console.Write("Месяц: "); int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 12: case 1: case 2: Console.WriteLine("Зима"); break;
            case 3: case 4: case 5: Console.WriteLine("Весна"); break;
            case 6: case 7: case 8: Console.WriteLine("Лето"); break;
            case 9: case 10: case 11: Console.WriteLine("Осень"); break;
            default: Console.WriteLine("Неверный месяц."); break;
        }
    }
    static void R4Task6()
    {
        Console.Write("Оценка: "); int g = int.Parse(Console.ReadLine());
        switch (g)
        {
            case 1: Console.WriteLine("Очень плохо"); break;
            case 2: Console.WriteLine("Неудовлетворительно"); break;
            case 3: Console.WriteLine("Удовлетворительно"); break;
            case 4: Console.WriteLine("Хорошо"); break;
            case 5: Console.WriteLine("Отлично"); break;
            default: Console.WriteLine("Неверная оценка."); break;
        }
    }
    static void R4Task7()
    {
        Console.Write("Первое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Операция (+, -, *, /): "); char op = Console.ReadLine()[0];
        Console.Write("Второе число: "); double b = double.Parse(Console.ReadLine());
        switch (op)
        {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/':
                if (b == 0) Console.WriteLine("Деление на ноль невозможно.");
                else Console.WriteLine(a / b);
                break;
            default: Console.WriteLine("Неизвестная операция."); break;
        }
    }
    static void R4Task8()
    {
        Console.Write("Буква (N, S, W, E): "); char c = char.ToUpper(Console.ReadLine()[0]);
        switch (c)
        {
            case 'N': Console.WriteLine("Север"); break;
            case 'S': Console.WriteLine("Юг"); break;
            case 'W': Console.WriteLine("Запад"); break;
            case 'E': Console.WriteLine("Восток"); break;
            default: Console.WriteLine("Неверное направление."); break;
        }
    }
    static void R4Task9()
    {
        Console.Write("Фигура (1 - круг, 2 - прямоугольник, 3 - треугольник): ");
        int f = int.Parse(Console.ReadLine());
        switch (f)
        {
            case 1:
                Console.Write("Радиус: "); double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь: {Math.PI * r * r}"); break;
            case 2:
                Console.Write("A B: "); var p = Console.ReadLine().Split();
                Console.WriteLine($"Площадь: {double.Parse(p[0]) * double.Parse(p[1])}"); break;
            case 3:
                Console.Write("Основание высота: "); var t = Console.ReadLine().Split();
                Console.WriteLine($"Площадь: {0.5 * double.Parse(t[0]) * double.Parse(t[1])}"); break;
            default: Console.WriteLine("Неверная фигура."); break;
        }
    }
    static void R4Task10()
    {
        Console.Write("Масть (1-4): "); int s = int.Parse(Console.ReadLine());
        switch (s)
        {
            case 1: Console.WriteLine("Пики"); break;
            case 2: Console.WriteLine("Трефы"); break;
            case 3: Console.WriteLine("Бубны"); break;
            case 4: Console.WriteLine("Червы"); break;
            default: Console.WriteLine("Неверная масть."); break;
        }
    }
    static void R4Task11()
    {
        Console.Write("Достоинство (6-14): "); int v = int.Parse(Console.ReadLine());
        switch (v)
        {
            case 11: Console.WriteLine("Валет"); break;
            case 12: Console.WriteLine("Дама"); break;
            case 13: Console.WriteLine("Король"); break;
            case 14: Console.WriteLine("Туз"); break;
            default: Console.WriteLine($"Номинал: {v}"); break;
        }
    }
    static void R4Task12()
    {
        Console.Write("Размер: "); string s = Console.ReadLine().ToUpper();
        switch (s)
        {
            case "XS": Console.WriteLine(42); break;
            case "S": Console.WriteLine(44); break;
            case "M": Console.WriteLine(46); break;
            case "L": Console.WriteLine(48); break;
            case "XL": Console.WriteLine(50); break;
            case "XXL": Console.WriteLine(52); break;
            default: Console.WriteLine("Неизвестный размер."); break;
        }
    }
    static void R4Task13()
    {
        Console.Write("Единица (1-5): "); int u = int.Parse(Console.ReadLine());
        Console.Write("Длина: "); double v = double.Parse(Console.ReadLine());
        double m;
        switch (u)
        {
            case 1: m = v / 10; break;
            case 2: m = v * 1000; break;
            case 3: m = v; break;
            case 4: m = v / 1000; break;
            case 5: m = v / 100; break;
            default: Console.WriteLine("Неверно."); return;
        }
        Console.WriteLine($"В метрах: {m}");
    }
    static void R4Task14()
    {
        Console.Write("Единица (1-5): "); int u = int.Parse(Console.ReadLine());
        Console.Write("Масса: "); double v = double.Parse(Console.ReadLine());
        double kg;
        switch (u)
        {
            case 1: kg = v; break;
            case 2: kg = v / 1_000_000; break;
            case 3: kg = v / 1000; break;
            case 4: kg = v * 1000; break;
            case 5: kg = v * 100; break;
            default: Console.WriteLine("Неверно."); return;
        }
        Console.WriteLine($"В килограммах: {kg}");
    }
    static void R4Task15()
    {
        Console.Write("HTTP код: "); int c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 200: Console.WriteLine("OK"); break;
            case 301: Console.WriteLine("Moved Permanently"); break;
            case 400: Console.WriteLine("Bad Request"); break;
            case 403: Console.WriteLine("Forbidden"); break;
            case 404: Console.WriteLine("Not Found"); break;
            case 500: Console.WriteLine("Internal Server Error"); break;
            case 502: Console.WriteLine("Bad Gateway"); break;
            default: Console.WriteLine("Неизвестный код."); break;
        }
    }
    static void R4Task16()
    {
        Console.Write("Валюта: "); string c = Console.ReadLine().ToUpper();
        switch (c)
        {
            case "USD": Console.WriteLine("Доллар США"); break;
            case "EUR": Console.WriteLine("Евро"); break;
            case "CNY": Console.WriteLine("Китайский юань"); break;
            case "RUB": Console.WriteLine("Российский рубль"); break;
            default: Console.WriteLine("Неизвестная валюта."); break;
        }
    }
    static void R4Task17()
    {
        Console.Write("Клавиша (W, A, S, D): "); char k = char.ToUpper(Console.ReadLine()[0]);
        switch (k)
        {
            case 'W': Console.WriteLine("Вперед"); break;
            case 'A': Console.WriteLine("Влево"); break;
            case 'S': Console.WriteLine("Назад"); break;
            case 'D': Console.WriteLine("Вправо"); break;
            default: Console.WriteLine("Неизвестная клавиша."); break;
        }
    }
    static void R4Task18()
    {
        Console.Write("Цвет радуги (1-7): "); int c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 1: Console.WriteLine("Красный"); break;
            case 2: Console.WriteLine("Оранжевый"); break;
            case 3: Console.WriteLine("Желтый"); break;
            case 4: Console.WriteLine("Зеленый"); break;
            case 5: Console.WriteLine("Голубой"); break;
            case 6: Console.WriteLine("Синий"); break;
            case 7: Console.WriteLine("Фиолетовый"); break;
            default: Console.WriteLine("Неверный номер."); break;
        }
    }
    static void R4Task19()
    {
        Console.Write("Режим АКПП (P, R, N, D, M): "); char m = char.ToUpper(Console.ReadLine()[0]);
        switch (m)
        {
            case 'P': Console.WriteLine("Parking"); break;
            case 'R': Console.WriteLine("Reverse"); break;
            case 'N': Console.WriteLine("Neutral"); break;
            case 'D': Console.WriteLine("Drive"); break;
            case 'M': Console.WriteLine("Manual"); break;
            default: Console.WriteLine("Неверный режим."); break;
        }
    }
    static void R4Task20()
    {
        Console.Write("Палец (1-5): "); int f = int.Parse(Console.ReadLine());
        switch (f)
        {
            case 1: Console.WriteLine("Большой"); break;
            case 2: Console.WriteLine("Указательный"); break;
            case 3: Console.WriteLine("Средний"); break;
            case 4: Console.WriteLine("Безымянный"); break;
            case 5: Console.WriteLine("Мизинец"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task21()
    {
        Console.Write("Планета (1-8): "); int p = int.Parse(Console.ReadLine());
        switch (p)
        {
            case 1: Console.WriteLine("Меркурий"); break;
            case 2: Console.WriteLine("Венера"); break;
            case 3: Console.WriteLine("Земля"); break;
            case 4: Console.WriteLine("Марс"); break;
            case 5: Console.WriteLine("Юпитер"); break;
            case 6: Console.WriteLine("Сатурн"); break;
            case 7: Console.WriteLine("Уран"); break;
            case 8: Console.WriteLine("Нептун"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task22()
    {
        Console.Write("Тариф (1-3): "); int t = int.Parse(Console.ReadLine());
        switch (t)
        {
            case 1: Console.WriteLine("Базовый: 300 руб, 5 ГБ"); break;
            case 2: Console.WriteLine("Студенческий: 200 руб, 15 ГБ"); break;
            case 3: Console.WriteLine("Безлимит: 600 руб, без лимита"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task23()
    {
        Console.Write("Квартал (1-4): "); int q = int.Parse(Console.ReadLine());
        switch (q)
        {
            case 1: Console.WriteLine("Январь, Февраль, Март"); break;
            case 2: Console.WriteLine("Апрель, Май, Июнь"); break;
            case 3: Console.WriteLine("Июль, Август, Сентябрь"); break;
            case 4: Console.WriteLine("Октябрь, Ноябрь, Декабрь"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task24()
    {
        Console.Write("Оценка (A, B, C, D, F): "); char g = char.ToUpper(Console.ReadLine()[0]);
        switch (g)
        {
            case 'A': Console.WriteLine("5"); break;
            case 'B': Console.WriteLine("4"); break;
            case 'C': Console.WriteLine("3"); break;
            case 'D': Console.WriteLine("2"); break;
            case 'F': Console.WriteLine("1"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task25()
    {
        Console.Write("Операция (U, I, D): "); char o = char.ToUpper(Console.ReadLine()[0]);
        switch (o)
        {
            case 'U': Console.WriteLine("Объединение"); break;
            case 'I': Console.WriteLine("Пересечение"); break;
            case 'D': Console.WriteLine("Разность"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task26()
    {
        Console.Write("Режим светофора (1-4): "); int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1: Console.WriteLine("Стоп"); break;
            case 2: Console.WriteLine("Приготовиться"); break;
            case 3: Console.WriteLine("Ехать"); break;
            case 4: Console.WriteLine("Ехать с осторожностью"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task27()
    {
        Console.Write("Цифра (0-9): "); int d = int.Parse(Console.ReadLine());
        switch (d)
        {
            case 0: Console.WriteLine("Ноль"); break;
            case 1: Console.WriteLine("Один"); break;
            case 2: Console.WriteLine("Два"); break;
            case 3: Console.WriteLine("Три"); break;
            case 4: Console.WriteLine("Четыре"); break;
            case 5: Console.WriteLine("Пять"); break;
            case 6: Console.WriteLine("Шесть"); break;
            case 7: Console.WriteLine("Семь"); break;
            case 8: Console.WriteLine("Восемь"); break;
            case 9: Console.WriteLine("Девять"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task28()
    {
        Console.Write("Римская цифра: "); char r = char.ToUpper(Console.ReadLine()[0]);
        switch (r)
        {
            case 'I': Console.WriteLine(1); break;
            case 'V': Console.WriteLine(5); break;
            case 'X': Console.WriteLine(10); break;
            case 'L': Console.WriteLine(50); break;
            case 'C': Console.WriteLine(100); break;
            case 'D': Console.WriteLine(500); break;
            case 'M': Console.WriteLine(1000); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task29()
    {
        Console.Write("Тип ТС (1-4): "); int t = int.Parse(Console.ReadLine());
        switch (t)
        {
            case 1: Console.WriteLine("A"); break;
            case 2: Console.WriteLine("B"); break;
            case 3: Console.WriteLine("C"); break;
            case 4: Console.WriteLine("D"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task30()
    {
        Console.Write("Тип двигателя (1-4): "); int t = int.Parse(Console.ReadLine());
        switch (t)
        {
            case 1: Console.WriteLine("Бензин"); break;
            case 2: Console.WriteLine("Дизель"); break;
            case 3: Console.WriteLine("Гибрид"); break;
            case 4: Console.WriteLine("Электричество"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task31()
    {
        Console.Write("Операция банкомата (1-4): "); int o = int.Parse(Console.ReadLine());
        switch (o)
        {
            case 1: Console.WriteLine("Запрос баланса..."); break;
            case 2: Console.WriteLine("Снятие наличных..."); break;
            case 3: Console.WriteLine("Пополнение счета..."); break;
            case 4: Console.WriteLine("Перевод средств..."); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task32()
    {
        Console.Write("Расширение: "); string e = Console.ReadLine().ToLower();
        switch (e)
        {
            case "txt": Console.WriteLine("Текстовый документ"); break;
            case "cs": Console.WriteLine("Исходный код C#"); break;
            case "html": Console.WriteLine("Веб-страница"); break;
            case "png": Console.WriteLine("Изображение"); break;
            case "mp3": Console.WriteLine("Аудиофайл"); break;
            default: Console.WriteLine("Неизвестное расширение."); break;
        }
    }
    static void R4Task33()
    {
        Console.Write("Элемент (1-5): "); int e = int.Parse(Console.ReadLine());
        switch (e)
        {
            case 1: Console.WriteLine("Водород (H)"); break;
            case 2: Console.WriteLine("Гелий (He)"); break;
            case 3: Console.WriteLine("Литий (Li)"); break;
            case 4: Console.WriteLine("Бериллий (Be)"); break;
            case 5: Console.WriteLine("Бор (B)"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task34()
    {
        Console.Write("Статус заказа: "); string s = Console.ReadLine().ToUpper();
        switch (s)
        {
            case "NEW": Console.WriteLine("Заказ создан"); break;
            case "PAID": Console.WriteLine("Заказ оплачен"); break;
            case "SHIPPED": Console.WriteLine("Заказ отправлен"); break;
            case "DELIVERED": Console.WriteLine("Заказ доставлен"); break;
            case "CANCELED": Console.WriteLine("Заказ отменен"); break;
            default: Console.WriteLine("Неизвестный статус."); break;
        }
    }
    static void R4Task35()
    {
        Console.Write("Система счисления (2, 8, 10, 16): "); int b = int.Parse(Console.ReadLine());
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        switch (b)
        {
            case 2: Console.WriteLine(Convert.ToString(n, 2)); break;
            case 8: Console.WriteLine(Convert.ToString(n, 8)); break;
            case 10: Console.WriteLine(n); break;
            case 16: Console.WriteLine(Convert.ToString(n, 16)); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task36()
    {
        Console.Write("Курс (1-4): "); int c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 1: Console.WriteLine("Первокурсник"); break;
            case 2: Console.WriteLine("Второй курс"); break;
            case 3: Console.WriteLine("Предвыпускной курс"); break;
            case 4: Console.WriteLine("Выпускник"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task37()
    {
        Console.Write("Климатическая зона (1-5): "); int z = int.Parse(Console.ReadLine());
        switch (z)
        {
            case 1: Console.WriteLine("Арктическая: полярная ночь, льды."); break;
            case 2: Console.WriteLine("Субарктическая: короткое лето, тундра."); break;
            case 3: Console.WriteLine("Умеренная: четыре сезона."); break;
            case 4: Console.WriteLine("Субтропическая: тепло и влажно."); break;
            case 5: Console.WriteLine("Тропическая: жарко круглый год."); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task38()
    {
        Console.Write("Класс пожарной опасности (1-5): "); int c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 1: Console.WriteLine("Низкая угроза, посещение разрешено."); break;
            case 2: Console.WriteLine("Малая угроза, посещение разрешено."); break;
            case 3: Console.WriteLine("Средняя угроза, ограничения на костры."); break;
            case 4: Console.WriteLine("Высокая угроза, запрет на костры."); break;
            case 5: Console.WriteLine("Чрезвычайная угроза, полный запрет."); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task39()
    {
        Console.Write("Разряд (1-5): "); int r = int.Parse(Console.ReadLine());
        switch (r)
        {
            case 1: Console.WriteLine("Юношеский"); break;
            case 2: Console.WriteLine("Взрослый"); break;
            case 3: Console.WriteLine("КМС"); break;
            case 4: Console.WriteLine("МС"); break;
            case 5: Console.WriteLine("МСМК"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task40()
    {
        Console.Write("Уровень доступа (G, U, M, A): "); char l = char.ToUpper(Console.ReadLine()[0]);
        switch (l)
        {
            case 'G': Console.WriteLine("Просмотр"); break;
            case 'U': Console.WriteLine("Просмотр и комментарии"); break;
            case 'M': Console.WriteLine("Модерация контента"); break;
            case 'A': Console.WriteLine("Полный доступ"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task41()
    {
        Console.Write("Нота (C, D, E, F, G, A, B): "); char n = char.ToUpper(Console.ReadLine()[0]);
        switch (n)
        {
            case 'C': Console.WriteLine("До"); break;
            case 'D': Console.WriteLine("Ре"); break;
            case 'E': Console.WriteLine("Ми"); break;
            case 'F': Console.WriteLine("Фа"); break;
            case 'G': Console.WriteLine("Соль"); break;
            case 'A': Console.WriteLine("Ля"); break;
            case 'B': Console.WriteLine("Си"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task42()
    {
        Console.Write("Кузов (1-5): "); int b = int.Parse(Console.ReadLine());
        switch (b)
        {
            case 1: Console.WriteLine("Седан: 4-5 мест, отдельный багажник."); break;
            case 2: Console.WriteLine("Хэтчбек: 4-5 мест, багажник совмещен."); break;
            case 3: Console.WriteLine("Универсал: увеличенный багажник."); break;
            case 4: Console.WriteLine("Купе: 2-4 места, спортивный."); break;
            case 5: Console.WriteLine("Внедорожник: повышенная проходимость."); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task43()
    {
        Console.Write("Датчик (M, D, S, W): "); char s = char.ToUpper(Console.ReadLine()[0]);
        switch (s)
        {
            case 'M': Console.WriteLine("Движение"); break;
            case 'D': Console.WriteLine("Открытие двери"); break;
            case 'S': Console.WriteLine("Дым"); break;
            case 'W': Console.WriteLine("Протечка воды"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task44()
    {
        Console.Write("Фаза Луны (1-4): "); int p = int.Parse(Console.ReadLine());
        switch (p)
        {
            case 1: Console.WriteLine("Новолуние"); break;
            case 2: Console.WriteLine("Первая четверть"); break;
            case 3: Console.WriteLine("Полнолуние"); break;
            case 4: Console.WriteLine("Последняя четверть"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task45()
    {
        Console.Write("Разделитель (/, \\): "); char s = Console.ReadLine()[0];
        switch (s)
        {
            case '/': Console.WriteLine("Unix/Linux"); break;
            case '\\': Console.WriteLine("Windows"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task46()
    {
        Console.Write("Поколение (2-5): "); int g = int.Parse(Console.ReadLine());
        switch (g)
        {
            case 2: Console.WriteLine("GPRS/EDGE, ~0.2 Мбит/с"); break;
            case 3: Console.WriteLine("UMTS/HSPA, ~2-42 Мбит/с"); break;
            case 4: Console.WriteLine("LTE, ~100 Мбит/с"); break;
            case 5: Console.WriteLine("NR, ~1 Гбит/с"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task47()
    {
        Console.Write("Порт: "); int p = int.Parse(Console.ReadLine());
        switch (p)
        {
            case 21: Console.WriteLine("FTP"); break;
            case 22: Console.WriteLine("SSH"); break;
            case 25: Console.WriteLine("SMTP"); break;
            case 80: Console.WriteLine("HTTP"); break;
            case 443: Console.WriteLine("HTTPS"); break;
            default: Console.WriteLine("Неизвестный порт."); break;
        }
    }
    static void R4Task48()
    {
        Console.Write("Режим стирки (1-5): "); int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1: Console.WriteLine("Хлопок: 60°C, 1000 об/мин"); break;
            case 2: Console.WriteLine("Синтетика: 40°C, 800 об/мин"); break;
            case 3: Console.WriteLine("Шерсть: 30°C, 400 об/мин"); break;
            case 4: Console.WriteLine("Быстрая 15 мин: 30°C, 600 об/мин"); break;
            case 5: Console.WriteLine("Отжим: 1200 об/мин"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task49()
    {
        Console.Write("Тарифная зона (1-3): "); int z = int.Parse(Console.ReadLine());
        switch (z)
        {
            case 1: Console.WriteLine("Пик: 8 руб/кВт·ч"); break;
            case 2: Console.WriteLine("Полупик: 5 руб/кВт·ч"); break;
            case 3: Console.WriteLine("Ночь: 2 руб/кВт·ч"); break;
            default: Console.WriteLine("Неверно."); break;
        }
    }
    static void R4Task50()
    {
        Console.Write("Состояние потока (Running, Suspended, Stopped, Aborted): ");
        string s = Console.ReadLine();
        switch (s)
        {
            case "Running": Console.WriteLine("Поток выполняется."); break;
            case "Suspended": Console.WriteLine("Поток приостановлен."); break;
            case "Stopped": Console.WriteLine("Поток завершен."); break;
            case "Aborted": Console.WriteLine("Поток прерван."); break;
            default: Console.WriteLine("Неизвестное состояние."); break;
        }
    }
}
