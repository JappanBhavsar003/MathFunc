using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Math.Pow(2, 3));

        //double c = Basic.Max(2.55555, 5.5555555);
        //double m = Basic.Min(5.44444, 9.555555);
        //Console.WriteLine("Maximum value is "+ c + "minimum value is " + m);
        //double y = Volume.Torus(2.5, 3);
        //Console.WriteLine(y);
        //Probability.Prob(5, 8);
        //double z = Area.Ellipse(2.55,5.55);
        //Console.WriteLine(z);
        //double a = Loan.IntersetInMonth(1.2, 10);
        //Console.WriteLine(Loan.LoanPayment(1000, a, 10));
        //Console.WriteLine(Factorial.Fact(6));
        Console.WriteLine(CommonFactor.GCD(70,100));
        Console.WriteLine(Area.Ellipse(1, 2)); 

        Console.ReadKey();
    }
}
