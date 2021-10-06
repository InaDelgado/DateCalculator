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
            }
        }

        static void InputDisplay()
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("       PLEASE, ENTER WITH DATAS TO INCREASE OR TO DECREASE DATETIME");
            Console.Write("       Date and Time (dd/mm/yyyy hh:mm): ");
            string date = Console.ReadLine();
            Console.Write("       Operation ('+', '-'): ");
            string operation = Console.ReadLine();
            Console.Write("       Amount for the operation: ");
            string amount = Console.ReadLine();
            Console.WriteLine("______________________________________________________________________________");

            Console.ReadLine();

            Calculate(date, operation, amount);
        }

        static void Calculate(string date, string operation, string amount)
        {
            var context = new DateManager(date, operation, amount);
            context.ValidateDateTime();

            context.ToManage();
            var calculatedDate = context.ExecuteStrategy();
            ResultDisplay(calculatedDate);
        }

        static void ResultDisplay(DateTime calculatedDate)
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.Write("       CALCULATION RESULT:  " + calculatedDate);
            Console.WriteLine("______________________________________________________________________________");
            Console.ReadLine();
        }
    }
}
