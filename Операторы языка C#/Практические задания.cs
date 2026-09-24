using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== ПРАКТИЧЕСКАЯ РАБОТА #2 =====\n");
            Console.WriteLine("1 - Арифметические операторы (1-10)");
            Console.WriteLine("2 - Операторы сравнения и равенства (1-10)");
            Console.WriteLine("3 - Логические операторы (1-10)");
            Console.WriteLine("4 - Побитовые операторы и сдвиги (1-10)");
            Console.WriteLine("5 - Операторы присваивания (1-10)");
            Console.WriteLine("6 - Тернарный и null-операторы (1-10)");
            Console.WriteLine("7 - Операторы типов и приведения (1-10)");
            Console.WriteLine("8 - Сложносоставные задания (1-35)");
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
                        case 1: A1(); break;
                        case 2: A2(); break;
                        case 3: A3(); break;
                        case 4: A4(); break;
                        case 5: A5(); break;
                        case 6: A6(); break;
                        case 7: A7(); break;
                        case 8: A8(); break;
                        case 9: A9(); break;
                        case 10: A10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 2:
                    switch (task)
                    {
                        case 1: B1(); break;
                        case 2: B2(); break;
                        case 3: B3(); break;
                        case 4: B4(); break;
                        case 5: B5(); break;
                        case 6: B6(); break;
                        case 7: B7(); break;
                        case 8: B8(); break;
                        case 9: B9(); break;
                        case 10: B10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 3:
                    switch (task)
                    {
                        case 1: C1(); break;
                        case 2: C2(); break;
                        case 3: C3(); break;
                        case 4: C4(); break;
                        case 5: C5(); break;
                        case 6: C6(); break;
                        case 7: C7(); break;
                        case 8: C8(); break;
                        case 9: C9(); break;
                        case 10: C10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 4:
                    switch (task)
                    {
                        case 1: D1(); break;
                        case 2: D2(); break;
                        case 3: D3(); break;
                        case 4: D4(); break;
                        case 5: D5(); break;
                        case 6: D6(); break;
                        case 7: D7(); break;
                        case 8: D8(); break;
                        case 9: D9(); break;
                        case 10: D10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 5:
                    switch (task)
                    {
                        case 1: E1(); break;
                        case 2: E2(); break;
                        case 3: E3(); break;
                        case 4: E4(); break;
                        case 5: E5(); break;
                        case 6: E6(); break;
                        case 7: E7(); break;
                        case 8: E8(); break;
                        case 9: E9(); break;
                        case 10: E10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 6:
                    switch (task)
                    {
                        case 1: F1(); break;
                        case 2: F2(); break;
                        case 3: F3(); break;
                        case 4: F4(); break;
                        case 5: F5(); break;
                        case 6: F6(); break;
                        case 7: F7(); break;
                        case 8: F8(); break;
                        case 9: F9(); break;
                        case 10: F10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 7:
                    switch (task)
                    {
                        case 1: G1(); break;
                        case 2: G2(); break;
                        case 3: G3(); break;
                        case 4: G4(); break;
                        case 5: G5(); break;
                        case 6: G6(); break;
                        case 7: G7(); break;
                        case 8: G8(); break;
                        case 9: G9(); break;
                        case 10: G10(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;

                case 8:
                    switch (task)
                    {
                        case 1: H1(); break;
                        case 2: H2(); break;
                        case 3: H3(); break;
                        case 4: H4(); break;
                        case 5: H5(); break;
                        case 6: H6(); break;
                        case 7: H7(); break;
                        case 8: H8(); break;
                        case 9: H9(); break;
                        case 10: H10(); break;
                        case 11: H11(); break;
                        case 12: H12(); break;
                        case 13: H13(); break;
                        case 14: H14(); break;
                        case 15: H15(); break;
                        case 16: H16(); break;
                        case 17: H17(); break;
                        case 18: H18(); break;
                        case 19: H19(); break;
                        case 20: H20(); break;
                        case 21: H21(); break;
                        case 22: H22(); break;
                        case 23: H23(); break;
                        case 24: H24(); break;
                        case 25: H25(); break;
                        case 26: H26(); break;
                        case 27: H27(); break;
                        case 28: H28(); break;
                        case 29: H29(); break;
                        case 30: H30(); break;
                        case 31: H31(); break;
                        case 32: H32(); break;
                        case 33: H33(); break;
                        case 34: H34(); break;
                        case 35: H35(); break;
                        default: Console.WriteLine("Нет такого задания."); break;
                    }
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }

    // 3.1
    static void A1() { Console.WriteLine("x = " + (17 / 5) + ", y = " + (17 % 5)); }
    static void A2() { int a = 5; Console.WriteLine("res = " + (++a * 2)); }
    static void A3() { int a = 5; Console.WriteLine("res = " + (a++ * 2)); }
    static void A4() { Console.WriteLine((7 / 2) + " и " + (7.0 / 2)); }
    static void A5() { Console.WriteLine(-15 % 4); }
    static void A6() { int x = 10; x = x++ + ++x; Console.WriteLine(x); }
    static void A7() { int max = int.MaxValue; Console.WriteLine(checked(max + 1)); }
    static void A8() { int max = int.MaxValue; Console.WriteLine(unchecked(max + 1)); }
    static void A9() { Console.WriteLine((1.0 / 0.0) + " и " + (0.0 / 0.0)); }
    static void A10() { int a = 8, b = 3; Console.WriteLine(a - b * 2 + a / b); }

    // 3.2
    static void B1() { Console.WriteLine((5 > 3) + ", " + (5 >= 5)); }
    static void B2() { Console.WriteLine("hello" == "hello"); }
    static void B3() { Console.WriteLine(double.NaN == double.NaN); }
    static void B4() { object a = new int[] { 1 }, b = new int[] { 1 }; Console.WriteLine(a == b); }
    static void B5() { Console.WriteLine(10 != 10.0); }
    static void B6() { Console.WriteLine(null == null); }
    static void B7() { Console.WriteLine((3 < 5) == (10 >= 20)); }
    static void B8() { Console.WriteLine(4 <= 4 && 5 > 2); }
    static void B9() { char c = 'b'; Console.WriteLine(c > 'a'); }
    static void B10() { Console.WriteLine(-0.0 == 0.0); }

    // 3.3
    static void C1() { Console.WriteLine(!true || false && true); }
    static void C2() { Console.WriteLine("Foo не вызван (&&)"); }
    static void C3() { Console.WriteLine("Foo вызван (&)"); }
    static void C4() { Console.WriteLine(true ^ false ^ true); }
    static void C5() { Console.WriteLine(!(5 > 2 || 3 < 1)); }
    static void C6() { bool a = true, b = false; Console.WriteLine(a && !b || b && !a); }
    static void C7() { int x = 5; Console.WriteLine(true || (x / 0 == 1)); }
    static void C8() { Console.WriteLine("Задание 8: нет в списке"); }
    static void C9() { Console.WriteLine("!(A && B) = !A || !B"); }
    static void C10() { Console.WriteLine("!(A || B) = !A && !B"); }

    // 3.4
    static void D1() { Console.WriteLine(5 & 3); }
    static void D2() { Console.WriteLine(5 | 3); }
    static void D3() { Console.WriteLine(5 ^ 3); }
    static void D4() { Console.WriteLine(~0); }
    static void D5() { Console.WriteLine(1 << 4); }
    static void D6() { Console.WriteLine(40 >> 2); }
    static void D7() { int n = 10; Console.WriteLine((n & 8) != 0); }
    static void D8() { int n = 0; n |= (1 << 2); Console.WriteLine(n); }
    static void D9() { int n = 31; n &= ~(1 << 4); Console.WriteLine(n); }
    static void D10() { Console.WriteLine((-16) >> 2); }

    // 3.5
    static void E1() { int p = 10; p += 5; Console.WriteLine(p); }
    static void E2() { int p = 10; p *= 2 + 3; Console.WriteLine(p); }
    static void E3() { int p = 12; p >>= 2; Console.WriteLine(p); }
    static void E4() { Console.WriteLine("x ??= y — присвоить, если x == null"); }
    static void E5() { string s = null; s ??= "default"; s ??= "custom"; Console.WriteLine(s); }
    static void E6() { int b = 1; b += 2; Console.WriteLine(b); }
    static void E7() { int q1 = 5, q2 = 10, q3; q3 = q1 = q2; Console.WriteLine(q3); }
    static void E8() { int m = 1; m <<= 3; m |= 2; Console.WriteLine(m); }
    static void E9() { int p = 15; p %= 4; Console.WriteLine(p); }
    static void E10() { int p = 7; p ^= 7; Console.WriteLine(p); }

    // 3.6
    static void F1() { int s = 75; Console.WriteLine(s >= 60 ? "Pass" : "Fail"); }
    static void F2() { int x = 5; Console.WriteLine(x > 10 ? 100 : x > 2 ? 50 : 0); }
    static void F3() { Console.WriteLine((true ? 10 : 15.5).GetType()); }
    static void F4() { string s = null; Console.WriteLine(s?.Length); }
    static void F5() { Console.WriteLine("int? (Nullable<int>)"); }
    static void F6() { string n = null; n = n ?? "Anonymous"; Console.WriteLine(n); }
    static void F7() { string a = null, b = "User", c = "Admin"; Console.WriteLine(a ?? b ?? c); }
    static void F8() { int a = 10; Console.WriteLine(false ? (a / 0) : 42); }
    static void F9() { Console.WriteLine("var x = condition ? 10 : \"text\" — не компилируется"); }
    static void F10() { int? cnt = null; Console.WriteLine(cnt?.GetHashCode() ?? -1); }

    // 3.7
    static void G1() { object o = "Hello"; Console.WriteLine(o is string); }
    static void G2() { object o = 123; string s = o as string; Console.WriteLine(s == null); }
    static void G3() { object o = 123; try { string s = (string)o; } catch (InvalidCastException) { Console.WriteLine("InvalidCastException"); } }
    static void G4() { Console.WriteLine(typeof(int) == typeof(Int32)); }
    static void G5() { Console.WriteLine(sizeof(long)); }
    static void G6() { Console.WriteLine(null is string); }
    static void G7() { object x = null; Console.WriteLine(x is null); }
    static void G8() { Console.WriteLine((int)3.99); }
    static void G9() { object o = 42; if (o is int val && val > 40) Console.WriteLine("да, val=" + val); }
    static void G10() { Console.WriteLine(default(int) + " и " + (default(string) ?? "null")); }

    // 35 сложносоставных заданий
    static void H1() { Console.WriteLine((5 > 3) && !(10 <= 2) || (4 == 5)); }
    static void H2() { Console.WriteLine(!(true && false) ^ (true || false && false)); }
    static void H3() { Console.WriteLine((10 & 6) == 2 && (10 | 6) == 14); }
    static void H4() { Console.WriteLine((15 >> 1 == 7) && (7 << 2 == 28)); }
    static void H5() { Console.WriteLine((8 > 5) && (3 + 2 * 4 == 11) && !(false || !true)); }
    static void H6() { Console.WriteLine((true || false) && (false || true) ^ (true && !false)); }
    static void H7() { Console.WriteLine((100 / 10 == 10) && (100 % 30 == 10) && !(5 - 5 != 0)); }
    static void H8() { Console.WriteLine((4 ^ 4) == 0 && (4 ^ 0) == 4 && (0 ^ 0) == 0); }
    static void H9() { int zero = 0; Console.WriteLine(!(5 != 5) && ((3 >= 3) || (10 / zero == 1))); }
    static void H10() { int zero = 0; Console.WriteLine((false && (10 / zero == 1)) || (true && (20 > 15))); }
    static void H11() { Console.WriteLine((12 & 10) > 5 || (12 | 10) < 15 && !(3 == 3)); }
    static void H12() { Console.WriteLine(((20 >> 2) == 5) ^ ((5 << 1) == 11)); }
    static void H13() { Console.WriteLine(!(!(true || false) && (true && !false))); }
    static void H14() { Console.WriteLine((7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15); }
    static void H15() { Console.WriteLine((5 & 1) == 1 && (6 & 1) == 0 && (7 & 1) == 1); }
    static void H16() { Console.WriteLine(((10 > 5 ? true : false) ^ (3 > 8 ? true : false)) && !false); }
    static void H17() { Console.WriteLine(!((5 > 2 && 10 > 20) || (3 == 3 && 4 <= 4))); }
    static void H18() { Console.WriteLine(((1 << 3) == 8) && ((16 >> 4) == 1) && ((2 << 2) == 8)); }
    static void H19() { Console.WriteLine(((10 & 7) == 2) || ((10 | 7) == 15) ^ !(4 > 1)); }
    static void H20() { Console.WriteLine(false || true && false || true && !false); }
    static void H21() { Console.WriteLine((25 % 4 == 1) && (17 / 3 == 5) && (17 % 3 == 2)); }
    static void H22() { Console.WriteLine(((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10)); }
    static void H23() { Console.WriteLine((true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2); }
    static void H24() { Console.WriteLine(!(true && !(false || !false))); }
    static void H25() { Console.WriteLine((~0 == -1) && (~(-1) == 0)); }
    static void H26() { Console.WriteLine(((8 & 4) == 0) && ((8 | 4) == 12) && ((8 ^ 4) == 12)); }
    static void H27() { Console.WriteLine(!(10 >= 10) || (5 < 3) && (2 == 2) || !(false)); }
    static void H28() { Console.WriteLine(((15 & ~1) == 14) && ((14 | 1) == 15)); }
    static void H29() { Console.WriteLine(((true || false) ? (false && true ? 10 : 20) : 30) == 20); }
    static void H30() { Console.WriteLine(((10 > 2) && (5 < 9)) ^ (!(4 >= 5) && (6 != 7))); }
    static void H31() { Console.WriteLine((7 & 3 & 1) == 1 && (7 | 3 | 1) == 7); }
    static void H32() { Console.WriteLine(((10 > 5 && 3 < 1) || (8 == 8 && !(5 > 10))) && (4 + 4 == 8)); }
    static void H33() { Console.WriteLine(!((!(true && false) || !(true || false)) && !false)); }
    static void H34() { Console.WriteLine(((32 >> 3 == 4) && (4 << 3 == 32)) ^ ((15 & 7) == 7 && (15 | 7) == 15)); }
    static void H35() { Console.WriteLine(((5 > 3 ? (2 > 1 ? true : false) : false) && !((10 > 20) || (30 < 15)))); }
}