namespace TestConsoleApplication
{
    class Program
    {
        static int Factorial(int x) //рассчет факториала
        {
            if (x == 1) return 1;

            return x * Factorial(x - 1);
        }
        static int Modify(double z) //преобразование в натуральные
        {
            if (z < 0)
            {
                z = -z;
            }
            z = Math.Round(z);
            return (int)z;

        }
        static int ChoosingForFactorial(double x = 0, double y = 0) //рассчет факториала
        {
            Console.WriteLine("Вычисление факториала возможно только для натуральных чисел.\nВведенные числа будут округлены, отрицательные будут преобразованны в противоположные.");
            Console.WriteLine("Факториал первого, или второго числа Вы хотите посчитать?");
            int fact = int.Parse(Console.ReadLine());
            switch (fact)
            {
                case 1:
                    x = Modify(x);
                    return Factorial((int)x);
                case 2:
                    y = Modify(y);
                    return Factorial((int)y);
                default:
                    return 0;
                    Console.Clear();
                    Console.WriteLine("Неверное значение");
                    Console.ReadLine();
                    Environment.Exit(0);
            }
        }
        static void InParams(out double x, out double y) //обработка введенных чисел
        {
            int counter = 0;
            bool rez;
            x = 0;
            do
            {
                Console.WriteLine("Введите значение №{0}", counter + 1);
                rez = double.TryParse(Console.ReadLine(), out y);
                if (rez == false)
                {
                    Console.Clear();
                    Console.WriteLine("Неверное значение");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (x == 0)
                {
                    x = y;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            while (counter != 2);
            Console.WriteLine("Вы ввели {0} и {1}", x, y);
        }
        static void Choosing(out int a) //выбор математической операции
        {
            Console.WriteLine("Выберите одну из доступных операций: \n 1. Add, \n 2. Subtract, \n 3. Multiply, \n 4. Divide, \n 5. Mod, \n 6. Sqrt, \n 7. Power, \n 8. Factorial");
            a = int.Parse(Console.ReadLine());
        }
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide,
            Mod,
            Sqrt,
            Power,
            Factorial
        }
        static void MathOp(double x, double y, Operation a)
        {
            double result = a switch
            {
                Operation.Add => x + y,
                Operation.Subtract => x - y,
                Operation.Multiply => x * y,
                Operation.Divide => x / y,
                Operation.Mod => x % y,
                Operation.Sqrt => Math.Pow(x, 1 / y),
                Operation.Power => Math.Pow(x, y),
                Operation.Factorial => ChoosingForFactorial(x, y)
            };

            Console.WriteLine("Результат операции равен {0}", result);
        }

        static void Main(string[] args)
        {
            int a;
            double x, y;
            InParams(out x, out y);
            Choosing(out a);
            if (0 <= a & a < 8)
            {
                Console.Clear();
                Console.WriteLine("Неверное значение");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                MathOp(x, y, (Operation)a);
            }
        }
    }
}