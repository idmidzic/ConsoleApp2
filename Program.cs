using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prvi, drugi;
            string op;

            try
            {

                prvi = double.Parse(args[0]);
                op = args[1];
                drugi = double.Parse(args[2]);

                switch (op)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", prvi, drugi, prvi + drugi);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", prvi, drugi, prvi - drugi);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", prvi, drugi, prvi * drugi);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", prvi, drugi, prvi / drugi);
                        break;
                }
            }
            catch (FormatException feks)
            {
                Console.WriteLine("Krivi broj!" + feks.Message);
            }
            //catch (FormatException eks)
            //{
            //Console.WriteLine("Neka greška!" + eks.Message);
            //}
        }
    }
}
