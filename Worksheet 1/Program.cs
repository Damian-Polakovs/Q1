namespace Worksheet_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
             * 
             * Name: Damian Polakovs
             * Date: 25/1/2023
             * Desc: Q1
             * 
             */

            PrintIntegersFor();
            PrintIntegersWhile();
            PrintIntegersDo();
            PrintExcludingFor();
            PrintDescendingFor();   

        }

        static private void PrintIntegersFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
            }
        }

        static private void PrintIntegersWhile()
        {
            int x = 0;
           
            while (x >= 40 && x <= 60)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        static private void PrintIntegersDo()
        {
            int y = 0;
            int counter = 0;
            do
            {


                counter = counter + y;
                Console.WriteLine(y);
            }

            while (y >= 40 && y <= 60);
            
        }

        static private void PrintExcludingFor()
        {
            for (int n = 40 ;n <= 60 && (n != 46 && n != 48); n++)
            {
                Console.WriteLine(n);
            }
        }

        static private void PrintDescendingFor()
        {
            for (int z = 60; z>=40; z--)
            {
                Console.WriteLine(z);
            }

        }
            
            
           
            
    }
}