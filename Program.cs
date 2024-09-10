namespace topic_4___random_numbers_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Enter a minimum value");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me your maximum number now");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your random numbers");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(generator.Next(n1, n2));
            }
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Im rolling dice,want in?");
            for (double j = 0.0; j < 2.0; j += 1.0)
            {
                Console.WriteLine(generator.Next(1, 7));
            }
            Console.Clear();
            Console.WriteLine("Enter a minimum value");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me your maximum number now");
            double d2 = Convert.ToDouble(Console.ReadLine());
            double answer;
            Console.WriteLine("Your random numbers");
            for (int i = 0; i < 5; i++)
            {
                answer = generator.Next(Convert.ToInt32(d1), Convert.ToInt32(d2));
                answer += generator.NextDouble();
                Console.WriteLine(answer);
            }
        }
    }
    }

