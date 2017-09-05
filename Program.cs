using System;

namespace ControlFlowExercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass.Exercise1();
            MainClass.Exercise2();
            MainClass.Exercise3();
            MainClass.Exercise4();
            MainClass.Exercise5();
        }

        public static void Exercise1 ()
        {
            var count = 0;
            for (var i = 1; i <= 100;i++)
            {
                if(i % 3 == 0) 
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        public static void Exercise2 ()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
					break; 
                }

                sum += Convert.ToInt32(input);
                
            };
            Console.WriteLine("Sum of all numbers is: " + sum);

        }

        public static void Exercise3 ()
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++) 
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public static void Exercise4 ()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("The Secret Number is " + number);
            for (var i = 0; i < 4;i++) 
            {
                Console.WriteLine("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }

        public static void Exercise5 () 
        {
            Console.WriteLine("Enter numbers seperated by commas: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = 0;

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);

                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("The max is: " + max);
        }
    }
}
