using System;

namespace FractionLib
{
    public class DopClass
    {
        public static long NSD(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                long min = Math.Min(a, b);
                long max = Math.Max(a, b);
                return NSD(max - min, min);
            }
        }
    }
    public class Fraction
    {
       public long Numerator { get; set; }
       public long Denominator { get; set; }
        public Fraction(long numerator, long denominator=1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction(string fraction)
        {
            string[] str= fraction.Split('/');
            Numerator = long.Parse(str[0]);
            Denominator = long.Parse(str[1]);
        }

        public static Fraction operator+(Fraction fract)
        {
            return new Fraction(fract.Numerator, fract.Denominator);
        }
        public static Fraction operator -(Fraction fract)
        {
            return new Fraction((-1)*fract.Numerator, fract.Denominator);
        }
        public static Fraction operator +(Fraction fract1, Fraction fract2)
        {
            long numeration = fract1.Numerator * fract2.Denominator+ fract2.Numerator * fract1.Denominator;
            long denominator = fract2.Denominator * fract1.Denominator;
            long nsd = DopClass.NSD(numeration, denominator);
            numeration /= nsd;
            denominator /= nsd;
            return new Fraction(numeration, denominator);
        }
        public static Fraction operator -(Fraction fract1, Fraction fract2)
        {

            long numeration = fract1.Numerator * fract2.Denominator - fract2.Numerator * fract1.Denominator;
            long denominator = fract2.Denominator * fract1.Denominator;
            long nsd = DopClass.NSD(numeration, denominator);
            numeration /= nsd;
            denominator /= nsd;
            return new Fraction(numeration, denominator);
        }
        public static Fraction operator *(Fraction fract1, Fraction fract2)
        {
            long numeration = fract1.Numerator *fract2.Numerator;
            long denominator = fract2.Denominator * fract1.Denominator;
            long nsd = DopClass.NSD(numeration, denominator);
            numeration /= nsd;
            denominator /= nsd;
            return new Fraction(numeration, denominator);
        }
        public static Fraction operator /(Fraction fract1, Fraction fract2)
        {

            long numeration = fract1.Numerator * fract2.Denominator;
            long denominator = fract1.Denominator * fract2.Numerator;
            long nsd = DopClass.NSD(numeration, denominator);
            numeration /= nsd;
            denominator /= nsd;
            return new Fraction(numeration, denominator);
        }
        public static bool operator>(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = fract1 - fract2;
            if (fract3.Numerator <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double ToDouble()
        {
            double fract1 = Numerator * (1.0)/ Denominator;
            return fract1;
        }
        public Fraction FractReduct()
        {
            long nsd = DopClass.NSD(Numerator, Denominator);
            Fraction fractNew = new Fraction(Numerator / nsd, Denominator / nsd);
            return fractNew;
        }
        public override string ToString()
        {
            string str = Numerator.ToString() + "/" + Denominator.ToString();
            return str;
        }
    }
}
