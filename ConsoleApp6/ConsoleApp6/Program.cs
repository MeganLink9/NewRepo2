using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Zavdan_4_6(string[] args)
        {
            /*
             * Даны два различных вещественных числа. Определить:
                а) какое из них больше;
                б) какое из них меньше.
             */

            Console.Write("Enter the number x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number y: ");
            int y = Convert.ToInt32(Console.ReadLine());


            int j = Math.Max(x, y);
            Console.WriteLine("More number: {0}", j);

            int k = Math.Min(x, y);
            Console.WriteLine("Smaller number: {0}", k);

            if (x == y)
                Console.WriteLine("numbers are equal");






        }

        static void Zavdan_4_22(string[] args)
        {
            /*
             * Дано натуральное число. Определить:
                а) является ли оно четным;
                б) оканчивается ли оно цифрой 7.
             */

            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 10 == 7)
                Console.WriteLine("The number {0} ends with 7 and is odd!", n);
            else if (n % 2 == 0)
                Console.WriteLine("The number {0} is even and does not end with 7!", n);
            else
                Console.WriteLine("The number {0} is odd and does not end with 7!", n);
        }

        static void Zavdan_4_38(string[] args)
        {
            /*
             * Определить, попадает ли точка с заданными координатами в область I.
             * Для простоты принять, что точка не попадает на границу этой области.
             */

            int[] x = new int[4];
            int[] y = new int[4];
            for (int i = 0; i < 4; ++i)
            {
                Console.Write("Введите (x" + i.ToString() + ",y" + i.ToString() + "): ");
                x[i] = Console.Read();
                y[i] = Console.Read();
                Console.ReadLine();
            }
            int a = (x[1] - x[0]) * (y[2] - y[1]) - (x[2] - x[1]) * (y[1] - y[0]);
            int b = (x[2] - x[0]) * (y[3] - y[2]) - (x[3] - x[2]) * (y[2] - y[0]);
            int c = (x[3] - x[0]) * (y[1] - y[3]) - (x[1] - x[3]) * (y[3] - y[0]);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                Console.WriteLine("Принадлежит треугольнику");
            }
            else
            {
                Console.WriteLine("Не принадлежит треугольнику");
            }
            Console.ReadKey();
        }

        static void Zavdan_4_54(string[] args)
        {
            /*
             * Пассажир должен был сдать в камеру хранения пустой чемодан в форме параллелепипеда размерами
                1a , 2 a и 3a см и коробку размерами 1b , 2b и 3b см.
                Оплачивать нужно каждый размещаемый предмет. Определить, сможет ли
                пассажир сэкономить на оплате, поместив коробку в чемодан так, что стороны
                чемодана и коробки будут параллельны либо перпендикулярны друг другу.
             */

            Console.Write("Введите двухзначное число: ");
            string chislo = Console.ReadLine();
            char a = '5';
            if (chislo.Contains('3') || chislo.Contains(a))
                Console.WriteLine("Вы ввели " + chislo + " в двузначном числе обнаружено цифру 3 и/или " + a.ToString());
            else
                Console.WriteLine("Цифр 3 или " + a.ToString() + " не обнаружено");
        }

        static void Zavdan_4_104(string[] args)
        {

            /*
             * Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) 
             * выводит на экран его название (понедельник, вторник, ..., воскресенье).
             */

            Console.Write("Enter the serial number of the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("TTuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }

        static void Zavdan_4_115(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string color = string.Empty;
            switch (((year + 6) % 10 + 2) / 2)
            {
                case 1:
                    color = "Green";
                    break;
                case 2:
                    color = "Red";
                    break;
                case 3:
                    color = "Yellow";
                    break;
                case 4:
                    color = "White";
                    break;
                case 5:
                    color = "Black";
                    break;
            }
            switch ((year - 3) % 12)
            {
                case 1:
                    Console.WriteLine($"{color} Mouse year");
                    break;
                case 2:
                    Console.WriteLine($"{color} Cow year");
                    break;
                case 3:
                    Console.WriteLine($"{color} Tiger year");
                    break;
                case 4:
                    Console.WriteLine($"{color} Rabbit year");
                    break;
                case 5:
                    Console.WriteLine($"{color} Dragon year");
                    break;
                case 6:
                    Console.WriteLine($"{color} Snake year");
                    break;
                case 7:
                    Console.WriteLine($"{color} Horse year");
                    break;
                case 8:
                    Console.WriteLine($"{color} Sheep year");
                    break;
                case 9:
                    Console.WriteLine($"{color} Monkey year");
                    break;
                case 10:
                    Console.WriteLine($"{ color} Cock year");
                    break;
                case 11:
                    Console.WriteLine($"{ color} Dog year");
                    break;
                case 0:
                    Console.WriteLine($"{color} Pig year");
                    break;
            }
        }
    }

}
