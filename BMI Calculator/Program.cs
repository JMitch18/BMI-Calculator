using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            float weight, height, bmi, answer;


            Console.Write("BMI VALUES\nUnderweight:  less than 18.5\nNormal:  between 18.5 and 24.9\n" +
                "Overweight:  between 25 and 29.9\nObese:  30 or greater\n\n");
            

            Console.Write("Enter your weight in kilograms: ");
            weight = float.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
           
            
            answer = weight / height;
            bmi = answer / height;

            if (bmi < 18.5)
            {

                Console.WriteLine("You're underweight! ");
                Console.ReadLine();

            }
            else if (bmi >= 8.5 && bmi <= 24.9)
            {

                Console.WriteLine("You have a normal weight! ");
                Console.ReadLine();

            }
            else if (bmi >= 25 && bmi <= 29.9)
            {

                Console.WriteLine("You are overweight! ");
                Console.ReadLine();

            }
            else
            {

                Console.WriteLine("You are obese!");
                Console.ReadLine();
                

            }

        }
    }
}
