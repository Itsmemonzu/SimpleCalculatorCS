using System;


namespace SimpleCalculator
{

    class Program
    {

        static void Main()
        {
            Console.Write("The number that you want to do operations to: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("The number that you want to do operations with: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose an Operator: Subtraction, Division, Multiplication & Addition: ");
            String numOperator = Console.ReadLine();

            if(numOperator.Equals("Addition") || numOperator.Equals("addition"))
            {
                Console.WriteLine("Your answer is:");
                Console.WriteLine(num1+num2);

            }else if(numOperator.Equals("Multiplication") || numOperator.Equals("multiplication"))
            {
                Console.WriteLine("Your answer is:");
                Console.WriteLine(num1*num2);

            }else if(numOperator.Equals("Division") || numOperator.Equals("division"))
            {
                Console.WriteLine("Your answer is:");

                Console.WriteLine(num1/num2);

            }else if(numOperator.Equals("Subtraction") || numOperator.Equals("subtraction"))
            {
                Console.WriteLine("Your answer is:");

                Console.WriteLine(num1-num2);    

            }else
            {
                Console.WriteLine("Math operation failed!");

            }



        }

    }
}


