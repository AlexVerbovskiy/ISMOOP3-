using System;
using System.Text;
using FractionLib;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Fraction fract1 = new Fraction ( 6, 18 );
            Fraction fract2 = new Fraction("5/17");
            Console.WriteLine("Унарна операція + з дробом fract1: {0}", +fract1);
            Console.WriteLine("Унарна операція - з дробом fract2: {0}", -fract2);
            Console.WriteLine("Бінарна операція + з дробами: {0}", fract1+fract2);
            Console.WriteLine("Бінарна операція - з дробами: {0}", fract1-fract2);
            Console.WriteLine("Бінарна операція * з дробами: {0}", fract1 * fract2);
            Console.WriteLine("Бінарна операція / з дробами: {0}", fract1 / fract2);
            Console.WriteLine("Результат порівняльної операції == : {0}", fract1 == fract2);
            Console.WriteLine("Результат порівняльної операції != : {0}", fract1 != fract2);
            Console.WriteLine("Результат порівняльної операції > : {0}", fract1 > fract2);
            Console.WriteLine("Результат порівняльної операції < : {0}", fract1 < fract2);
            Console.WriteLine("Результат порівняльної операції >= : {0}", fract1 >= fract2);
            Console.WriteLine("Результат порівняльної операції <= : {0}", fract1 <= fract2);
            Console.WriteLine("Вивід дробу fract2 форматом double: {0}", fract2.ToDouble());
            Console.WriteLine("Результат скорочення дробу fract1: {0}", fract1.FractReduct());
            Console.WriteLine("Вивід дробу fract1 рядком: {0}", fract1);
        }
    }
}
