using System.Runtime.CompilerServices;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string start = "KALKULATOR";
                Console.WriteLine(start);

                while(true)
                {
                    Console.WriteLine("I liczba");
                    var number1 = GetInput();

                    Console.WriteLine("OPERACJA. Możliwe: '+', '-', '*', '/',");
                    var operation = Console.ReadLine();

                    Console.WriteLine("II liczba");
                    var number2 = GetInput();

                    var x = Calculate(number1, number2, operation);
                    Console.WriteLine($"Wynik: {x}.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            static double GetInput()
            {
                if (!double.TryParse(Console.ReadLine(), out double input))
                    throw new Exception("Podana wartość nie jest liczbą.");

                return input;
            }

            static double Calculate(double number1, double number2, string operation) 
            {
                switch (operation)
                {
                    case "+":
                        return number1 + number2;
                    case "-":
                        return number1 - number2;
                    case "*":
                        return number1 * number2;
                    case "/":
                        return number1 / number2;
                    default:
                        throw new Exception("ZŁA OPERACJA!!!");
                }
            }
        }
    }
}