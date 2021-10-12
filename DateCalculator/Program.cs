using DateCalculator.Models;
using System;

namespace DateCalculator.System
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }

        static void InputDisplay()
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("       PLEASE, ENTER WITH DATAS TO INCREASE OR TO DECREASE DATETIME");
            Console.Write("       Date and Time (dd/mm/yyyy hh:mm): ");
            string date = Console.ReadLine();
            Console.Write("       Operation ('increase' or 'decrease'): ");
            string opInput = Console.ReadLine();
            Console.Write("       Amount for the operation: ");
            string amount = Console.ReadLine();
            Console.WriteLine("______________________________________________________________________________");

            var calculatedDate = Calculate(date, opInput, amount);

            ResultDisplay(calculatedDate);
        }

        static string Calculate(string date, string opInput, string amount)
        {
            var context = new DateManager(date, opInput, amount);
            context.ValidateDateTime();

            context.ToManage();
            Operation operation = context.ExecuteFactory();
            return operation.Calculate();
        }

        static void ResultDisplay(string calculatedDate)
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("       CALCULATION RESULT:  " + calculatedDate);
            Console.WriteLine("______________________________________________________________________________");
            Console.ReadLine();
        }
    }
}
