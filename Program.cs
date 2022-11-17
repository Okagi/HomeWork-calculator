using System;

namespace Калькулатор
{
    using System;

    class Program
    {
        static void Main()
        {

            double fn;
            double sn;
            double total;
            char oper;


            Console.WriteLine("Enter first the number:");
            fn = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator: '+' '-' '*' '/'");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second the number:");
            sn = Convert.ToDouble(Console.ReadLine());




            {
                if (oper == '+')
                {
                    total = fn + sn;
                    Console.WriteLine("result " +  fn + " + " + sn + " = " + total + ".");
                }

                else if (oper == '-')
                {
                    total = fn - sn;
                    Console.WriteLine("result " + fn + " - " + sn + " = " + total + ".");
                }

                else if (oper == '*')
                {
                    total = fn * sn;
                    Console.WriteLine("result " + fn + " * " + sn + " = " + total + ".");
                }

                else if (oper == '/')
                { 
                    total = fn / sn;
                    try
                    {

                        Console.WriteLine("result " + fn + " / " + sn + " = " + total + ".");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка, на ноль делить нельзя");
                    }
                }

                else if (sn == 0)
                {
                    total = fn * sn;
                    Console.WriteLine("result " + fn + " * " + sn + " = " + 0 + ".");

                }

                else if (sn == 0)
                {
                    total = fn / sn;
                    Console.WriteLine("result " + fn + " / " + sn + " = " + 0 + ".");
                }

                else if (fn == 0)
                {
                    total = fn * sn;
                    Console.WriteLine("result " + fn + " * " + sn + " = " + 0 + ".");

                }

                else if (fn == 0)
                {
                    total = fn / sn;
                    Console.WriteLine("result " + fn + " / " + sn + " = " + 0 + ".");
                }
              
                else
                {
                    Console.WriteLine("unknown operator");
                }

            }

        }

    }

}