using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_lesson_app
{
    public class Frac
    {
        public Exception ZeroDenominatorException = new Exception("Cannot divide by zero in fratcion.");
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Frac(int Numerator, int Denominator)
        {
            if (Denominator == 0) throw ZeroDenominatorException;
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

       
        private static int CommonDenominator(Frac f1, Frac f2)
        {
            return f1.Denominator * f2.Denominator;
        }
        private static Frac Reduce(Frac f)
        {
            double Numerator = f.Numerator;
            double Denominator = f.Denominator;
            for (int i = Math.Abs((int)Numerator); i > 0; i--)
            {
                
                if ((Numerator / i == (double)((int)Numerator / i)) && (Denominator / i == (double)((int)Denominator / i)))
                {
                    return new Frac((int)Numerator / i, (int)Denominator / i);
                }

            }
            return f;
        }
       
        private void ToAnotherDenominator(int NewDenominator)
        {
            this.Numerator = this.Numerator * (NewDenominator / this.Denominator);
            this.Denominator = NewDenominator;
            

        }
        public static Frac operator +(Frac f1, Frac f2)
        {
            int gcd = CommonDenominator(f1, f2);
            f1.ToAnotherDenominator(gcd);
            f2.ToAnotherDenominator(gcd);
            
            return Reduce(new Frac(f1.Numerator + f2.Numerator, gcd));
        }
        public static Frac operator *(Frac f1, Frac f2)
            =>Reduce(new Frac(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator));
        public static Frac operator /(Frac f1, Frac f2)
            => Reduce(new Frac(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator));
        
        public static Frac operator -(Frac f1, Frac f2) 
            =>Reduce((f1 + new Frac(-f2.Numerator, f2.Denominator)));

    }
}
