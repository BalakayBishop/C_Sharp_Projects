using System;

namespace CSC670_Project1
{
    class Program
    {
        private static string weightType;
        private static string BMI;
        private static double weightLBS;
        private static double weightKilo;
        private static double heightIN;
        private static double heightM;
        private static double result;

        static void Main(string[] args)
        {
            Console.WriteLine("\t   BMI Calculator\n");
            Console.WriteLine(" Would you like to use pounds or kilograms?");
            Console.Write(" Enter \"lbs\" for pounds or \"kilo\" for kilograms: ");
            weightType = Convert.ToString(Console.ReadLine());

            if (weightType.Equals("lbs"))
            {
                Console.Write("\n Please enter your weight in pounds: ");
                weightLBS = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Please enter your height in inches: ");
                heightIN = Convert.ToDouble(Console.ReadLine());

                result = (weightLBS * 703) / (Math.Pow(heightIN, 2));
                result = Math.Round(result, 2);
                
                if (result < 18.5)
                {
                    BMI = "Underweight";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 18.5 && result < 24.9)
                {
                    BMI = "Normal";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 24.9 && result < 29.9)
                {
                    BMI = "Overweight";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 30)
                {
                    BMI = "Obese";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
            }
            else if (weightType.Equals("kilo"))
            {
                Console.Write("\n Please enter your weight in kilograms: ");
                weightKilo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Please enter your height in meters: ");
                heightM = Convert.ToDouble(Console.ReadLine());

                result = (weightKilo) / (Math.Pow(heightM, 2));
                result = Math.Round(result, 2);

                if (result < 18.5)
                {
                    BMI = "Underweight";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 18.5 && result < 24.9)
                {
                    BMI = "Normal";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 24.9 && result < 29.9)
                {
                    BMI = "Overweight";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
                else if (result > 30)
                {
                    BMI = "Obese";
                    Console.WriteLine("\n Your BMI is {0} ({1})", result, BMI);
                }
            }
        }
    }
}
