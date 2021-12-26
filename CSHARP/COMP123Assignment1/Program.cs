using System;
/* DANIYAL AHMED
 * 301152472
 * 1/23/2020 
 */

namespace COMP123Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational numberA = new Rational();
            Rational numberB = new Rational(3);
            Rational numberC = new Rational(3, 8);
            int a = 5;
            int b = 9;
            Rational numberD = new Rational(a, b);

            Console.WriteLine("The two pairs of fractions are: ");
            numberC.ToString();
            numberD.ToString();
            Console.WriteLine("Added together equals: ");
            numberC.IncreaseBy(numberD);
            numberC.ToString();
            Console.WriteLine("Subtracting second from first equals: ");
            numberC.DecreaseBy(numberD);
            numberC.ToString();
        }
    }
    public class Rational
    {
        //FIELDS
        private int numerator = 100;
        private int denominator = 100;

        //PROPERTIES
        public int Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                this.numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return this.denominator;
            }
            private set
            {
                if (value != 0)
                {
                    this.denominator = value;
                }
                
            }
        }
        //CONSTRUCTOR
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }
        //METHODS
        public override string ToString()
        {
            return $"num:{this.Numerator}den:{this.Denominator}";
        }    
        public void IncreaseBy(Rational other)
        {
                //LIKE TERMS
                this.Numerator = this.Numerator * other.Denominator;
                this.Denominator = this.Denominator * other.Denominator;
                other.Numerator = other.Numerator * this.Denominator;
                other.Denominator = other.Denominator * this.Denominator;
                //INCREASE
                this.Numerator += other.Numerator;
                this.Denominator += other.Denominator;
        }
        public void DecreaseBy(Rational other)
        {
                //LIKE TERMS
                this.Numerator = this.Numerator * other.Denominator;
                this.Denominator = this.Denominator * other.Denominator;
                other.Numerator = other.Numerator * this.Denominator;
                other.Denominator = other.Denominator * this.Denominator;
                //DECREASE
                this.Numerator -= other.Numerator;
                this.Denominator -= other.Denominator;
        }


    }
}

