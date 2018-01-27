using System;

namespace Formula
{
    //This class is use for only Basic Maths Function like addition,multiplication,etc.

    public static class Basic
    {
        public static double Sum(double num1, double num2)
        {
            return (num1 + num2);
        }
        public static double Abstraction(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Multiplication(double num1, double num2)
        {
            return (num1 * num2);
        }
        public static double Division(double num1, double num2)
        {
            return (num1 / num2);
        }
        public static double Min(double num1, double num2)
        {
            double c = Math.Min(num1, num2);
            return c;
        }
        public static double Max(double num1, double num2)
        {
            double c = Math.Max(num1, num2);
            return c;
        }
        public static double Avg(double num1, double num2)
        {
            double c = (num1 + num2) / 2;
            return c;
        }
        public static double Power(double basevalue, double powerValue)
        {
            return (Math.Pow(basevalue, powerValue));
        }
    }

    //This class is use for finding Area for particular Shapes

    public static class Area
    {
        public static double Circle(double Radius)
        {
            double a = (Math.PI) * (Radius * Radius);
            return a;
        }
        public static double Triangle(double Base, double Veriticle_Height)
        {
            double a = (Base * Veriticle_Height) / 2;
            return a;
        }
        public static double Rectangle(double Width, double Height)
        {
            return (Width * Height);
        }
        public static double Trapzoid(double length1, double length2, double height)
        {
            double a = (length1 + length2) / 2;
            return (a * height);
        }
        public static double Ellipse(double length1, double length2)
        {
            double a = (length2 * length1);
            return (Math.PI * a);
        }
        public static double Square(double length)
        {
            return (length * length);
        }
        public static double Parallelogram(double height, double Base)
        {
            return (height * Base);
        }
        public static double Sector(double radius, double angle)
        {
            double a = ((radius * radius) * angle);
            return (a / 2);
        }
    }

    //This class is use for finding Volume of particular Shapes.

    public static class Volume
    {
        public static double Cube(double lenght)
        {
            return (lenght * lenght * lenght);
        }
        public static double Rectangular_Prism(double height, double width, double length)
        {
            return (height * width * length);
        }
        public static double Cylinder(double radius, double height)
        {
            double a = ((radius * radius) * height);
            return (Math.PI * a);
        }
        public static double Pyramid(double length, double width, double height)
        {
            double c = ((length * width) / height);
            return (c / 3);
        }
        public static double Cone(double radius, double height)
        {
            double a = ((radius * radius) * height);
            return ((Math.PI * a) / 3);
        }
        public static double Torus(double inner_radius, double outer_radius)
        {
            double a = (2 * (inner_radius * inner_radius * outer_radius));
            return (Math.Pow(Math.PI, 2) * a);
        }
        public static double Sphere(double radius)
        {
            double a = ((4 * radius * radius * radius) / 3);
            return (a * Math.PI);
        }
    }

    //This class is use for Probability 

    public static class Probability
    {
        public static double Prob(double NumOfProbaleOutcome, double TotalPossibleOutcomes)
        {
            return (NumOfProbaleOutcome / TotalPossibleOutcomes);
        }


    }

    //This class is use for Trigonometry 

    public static class Trigonometry
    {
        public static double Sin(double Angle)
        {
            return (Math.Sin(Angle));
        }
        public static double Cos(double Angle)
        {
            return (Math.Cos(Angle));
        }
        public static double Tan(double Angle)
        {
            return (Math.Tan(Angle));
        }
        public static double SinAngle(double vlaue)
        {
            return (Math.Asin(vlaue));
        }
        public static double CosAngle(double value)
        {
            return (Math.Acos(value));
        }
        public static double TanAngle(double value)
        {
            return (Math.Atan(value));
        }
    }

    // This class is  consist of Factorial Function

    public static class Factorial
    {
        public static double Fact(double value)
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return (value * Fact(value - 1));
            }
        }
    }

    //This class Consist of Combination  Formula

    public static class Combination
    {
        public static double nCr(double valueofN, double valueofR)
        {
            double a = (Factorial.Fact(valueofN));
            double b = (Factorial.Fact(valueofR) * Factorial.Fact(valueofN - valueofR));
            return (a / b);
        }
    }

    //This class Consist of Permutation Formula

    public static class Permutation
    {
        public static double nPr(double valueofN, double valueofR)
        {
            double a = (Factorial.Fact(valueofN));
            double b = (Factorial.Fact(valueofN - valueofR));
            return (a / b);
        }
    }

    // This class Consist of Simple Interest

    public static class SimpleIneterst
    {
        public static double Interest(double principal, double rate, double time)
        {
            double a = (principal * rate * time);
            return (a / 100);
        }
        public static double Principal(double simpleInterest, double rate, double time)
        {
            double a = (100 * simpleInterest);
            double b = (rate * time);
            return (a / b);
        }
        public static double Rate(double simpleInterest, double principal, double time)
        {
            double a = (100 * simpleInterest);
            double b = (principal * time);
            return (a / b);
        }
        public static double Time(double simpleInterest, double rate, double principal)
        {
            double a = (100 * simpleInterest);
            double b = (rate * principal);
            return (a / b);
        }
    }

    //This class Consist of Compound Interest

    public static class CompoundInteresr
    {
        public static double CompInterest(double principal, double rate, double nYear)
        {
            double a = (1 + (rate / 100));
            double b = (principal * a);
            return (Math.Pow(b, nYear));
        }
    }

    //This class Consist of Profit 

    public static class Profit
    {
        public static double Prof(double costPrice, double SellPrice)
        {
            return (SellPrice - costPrice);
        }

    }

    //This class Consist of Loss

    public static class Loss
    {
        public static double Los(double costPrice, double SellPrice)
        {
            return (costPrice - SellPrice);
        }
    }

    //This class is consist of Loan calculation

    public static class Loan
    {
        public static double IntersetInMonth(double annualInterest, double numOfMonthsOfPaying)
        {
            double a = (annualInterest / 100);
            double b = (a / numOfMonthsOfPaying);
            return b;
        }

        public static double LoanPayment(double actualPayment, double interestRate, double numOfPayment)
        {
            double a = Math.Pow((1 + interestRate), (numOfPayment));
            a = (1 / a);
            double b = (1 - a);
            double c = (actualPayment * interestRate);
            return (c / b);
        }
    }

    //This class is consist of Highest Common Factor

    public static class CommonFactor
    {
        public static double HCF(double number1, double number2)
        {
            double HighestCommonFactor = GCD(number1, number2);
            return HighestCommonFactor;
        }
        public static double LCM(double Value1, double Value2)
        {
            double HighestCommonFactor = HCF(Value1, Value2);
            double LowestCommonFactor = ((Value2 * Value1) / HighestCommonFactor);
            return LowestCommonFactor;
        }
        public static double GCD(double num1, double num2)
        {
            if (num1 == 0)
            {
                return num2;
            }
            while (num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            return num1;
        }

    }

    //This class is consist of Speed and Related Methods

    public static class Speed
    {
        public static double GetSpeed(double distance, double time)
        {
            return (distance / time);
        }
        public static double GetMS(double speedInKMH)
        {
            return ((speedInKMH * 18) / 5);
        }
        public static double GetKMH(double speedInMS)
        {
            return ((speedInMS * 5) / 18);
        }
        public static double GetDistance(double speed,double time)
        {
            return (speed * time);
        }
        public static double GetTime(double distance,double speed)
        {
            return (distance / speed);
        }
    }
    //
}
