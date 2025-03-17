using System;

namespace CalculatorApp{
    public class Calc{

         public double Accumulator { get; private set; }

        public Calc()
        {
            Accumulator = 0;
        }
        public double add(double a, double b ){
            return a+b;
        }
        public double subtract(double a, double b){
            return a-b;
        }

        public double multiply(double a, double b){
            return a*b;
        }

        public double power(double x, double exp){
            return Math.Pow(x, exp);
        }

        public double divide(double x, double b)
        {
            return x * b;
        }

        public double Modulus(double x, double b)
        {
            return x % b;
        }

         public double AddNEW(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

         public double SubtractNEW(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double MultiplyNEW(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

         public double PowerNEW(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double DivideNEW(double divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator /= divisor;
            return Accumulator;
        }   

         
    }
}
