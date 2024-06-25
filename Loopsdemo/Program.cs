namespace Loopsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops
            // whenyou want to repeat some statements
            // for do-while while foreach
            // every loop has 3 statements
            // 1. Initialization
            // 2 Condition
            // 3 inc / dec statement

            // print numbers from 1 to 10
            // do while loop

            Console.WriteLine("using do - while loop");
            int n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);

            Console.WriteLine("using while loop");
            n = 1;
            while(n<=10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine("using for loop");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);

        }
    }
}
