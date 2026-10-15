# Рубежный практический контроль: Комплексный практикум по базовым конструкциям C#
**Выполнял**: Филаткин А. С.

![Скрин -1го этапа](https://github.com/FitAl-lab/College-Program/blob/e85ce9791782c534b2dcfb2c0cde31b662d2e7c4/%D0%A0%D1%83%D0%B1%D0%B5%D0%B6%D0%BD%D1%8B%D0%B9%20%D0%BF%D1%80%D0%B0%D0%BA%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D0%B9%20%D0%BA%D0%BE%D0%BD%D1%82%D1%80%D0%BE%D0%BB%D1%8C/screenshots/1.png)

```scharp
using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("--- Этап 1 ---\n");

      int volume = 500;
      int torque = 25;
      int syrupTemp = 20;
      int defect = 1;

      uint data = 0;
      data = data | (uint)volume;
      data = data | ((uint)torque << 10);
      data = data | ((uint)syrupTemp << 18);
      data = data | ((uint)defect << 25);

      int outVolume = (int)data & 1023;
      int outTorque = ((int)data >> 10) & 255;
      int outTemp = ((int)data >> 18) & 127;
      int outDefect = ((int)data >> 25) & 3;

      uint temp = data;
      int parity = 0;
      for (int i = 0; i < 32; i++)
      {
          parity = parity ^ (int)(temp & 1);
          temp = temp >> 1;
      }

      Console.WriteLine("Объём: " + outVolume + " мл");
      Console.WriteLine("Момент: " + outTorque + " Н*м");
      Console.WriteLine("Температура: " + outTemp + " C");
      Console.WriteLine("Брак: " + outDefect);
      Console.WriteLine("Чётность: " + parity);
      Console.WriteLine();
    } 
}
```
