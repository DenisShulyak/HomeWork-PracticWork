using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)");
            int y;
            Console.WriteLine("Дана функция: ");
            Console.WriteLine(" y = 7x^2 - 3x + 4 ");
            Console.WriteLine("Введите значение х: ");
            int x = int.Parse(Console.ReadLine());
            y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("Полученная функция равна: " + y);
            Console.ReadLine();
            Console.WriteLine("2)");
            Console.WriteLine("Введите радиус окружности: ");
            double R = int.Parse(Console.ReadLine());
            double power = 2;
            int k = 2;
            double S = Math.PI * Math.Pow(R, power);
            double C = k * Math.PI * R;
            Console.WriteLine("Площадь окружности: " + S);
            Console.WriteLine("Длина окружности: " + C);
            Console.ReadLine();

            Console.WriteLine("3)");
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            int numberSM = int.Parse(Console.ReadLine());
            int OneMetrInSm = 100;
            int numberM = numberSM / OneMetrInSm;
            Console.WriteLine("Расстояние в метрах: " + numberM);
            Console.WriteLine("4)");
            int quantityDays = 234;
            int quantityDaysInWeek = 7;
            int quantityFullWeek = quantityDays / quantityDaysInWeek;
            Console.WriteLine("Количество полных недель за данный период: " + quantityFullWeek);

            Console.ReadLine();
            Console.WriteLine("5)");
            Console.WriteLine("Введите двухзначное число: ");
            int number1 = int.Parse(Console.ReadLine());
            int ForFindTensOrUnits1 = 10;

            int tens1 = number1 / ForFindTensOrUnits1;
            int units1 = number1 % ForFindTensOrUnits1;
            int sum1 = tens1 + units1;
            int composition1 = tens1 * units1;
            Console.WriteLine("Число десятков: " + tens1);
            Console.WriteLine("Число едениц: " + units1);
            Console.WriteLine("Сумма: " + sum1);
            Console.WriteLine("Произведение: " + composition1);

            Console.ReadLine();
            Console.WriteLine("6)");
            Console.WriteLine("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            int forThousandOrHundreds = 1000;
            int forHundredsOrTens = 100;
            int forTensOrUnits = 10;
            int thousands = number / forThousandOrHundreds;
            int hundreds = number % forThousandOrHundreds / forHundredsOrTens;
            int tens = number % forThousandOrHundreds % forHundredsOrTens / forTensOrUnits;
            int units = number % forThousandOrHundreds % forHundredsOrTens % forTensOrUnits;

            int sum = tens + units + thousands + hundreds;
            int composition = tens * units * thousands * hundreds;

            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + composition);

            Console.ReadLine();
            Console.WriteLine("7)");
            int number2 = 456;
            Console.WriteLine("Дано число: " + number2);
            int forHundredsOrTens2 = 100;
            int forTensOrUnits2 = 10;

            int leftNumber = number2 / forHundredsOrTens2;
            int midNumber = number2% forHundredsOrTens2/ forTensOrUnits2;
            int rightNumber = number2 % forHundredsOrTens2 % forTensOrUnits2;
            int additionalNumber = midNumber;
            midNumber = rightNumber;
            rightNumber = additionalNumber;
            number2 = leftNumber * forHundredsOrTens2 + midNumber * forTensOrUnits2 + rightNumber;
            Console.WriteLine("Искомое число: " + number2);

            Console.ReadLine();
            Console.WriteLine("8)");
            Random rand = new Random();
            int FalseOrTrue1;
            FalseOrTrue1 = rand.Next(0, 2);
            int FalseOrTrue2;
            FalseOrTrue2 = rand.Next(0, 2);
            bool X;
            bool Y;
            bool D;
            if(FalseOrTrue1 == 0 && FalseOrTrue2 == 0)
            {
                X = false;
                Y = false;
                Console.WriteLine("X = " + X);
                Console.WriteLine("Y = " + Y);

                D = !X & !Y;
                Console.WriteLine("!X и !Y = " + D);
                D = X | (!X & Y);
                Console.WriteLine("X или (не Х и Y) = " + D);
                D = (!X & Y) | Y;
                Console.WriteLine("(не X и Y) или Y = " + D);

            }
            else if(FalseOrTrue1 == 1 && FalseOrTrue2 == 1)
            {
                X = true;
                Y = true;
                Console.WriteLine("X = " + X);
                Console.WriteLine("Y = " + Y);

                D = !X & !Y;
                Console.WriteLine("!X и !Y = " + D);
                D = X | (!X & Y);
                Console.WriteLine("X или (не Х и Y) = " + D);
                D = (!X & Y) | Y;
                Console.WriteLine("(не X и Y) или Y = " + D);
            }
            else if (FalseOrTrue1 == 0 && FalseOrTrue2 == 1)
            {
                X = false;
                Y = true;
                Console.WriteLine("X = " + X);
                Console.WriteLine("Y = " + Y);

                D = !X & !Y;
                Console.WriteLine("!X и !Y = " + D);
                D = X | (!X & Y);
                Console.WriteLine("X или (не Х и Y) = " + D);
                D = (!X & Y) | Y;
                Console.WriteLine("(не X и Y) или Y = " + D);
            }
            else if (FalseOrTrue1 == 1 && FalseOrTrue2 == 0)
            {
                X = true;
                Y = false;
                Console.WriteLine("X = " + X);
                Console.WriteLine("Y = " + Y);

                D = !X & !Y;
                Console.WriteLine("!X и !Y = " + D);
                D = X | (!X & Y);
                Console.WriteLine("X или (не Х и Y) = " + D);
                D = (!X & Y) | Y;
                Console.WriteLine("(не X и Y) или Y = " + D);
            }


            Console.ReadLine();

        }
    }
}
