


namespace Fibonacci_Wout_Vullings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel stappen van de Fibonacci-reeks wil je genereren?");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 1;
            int b = 2;

            // Als n minimaal 1 is, print de eerste stap
            if (n >= 1)
            {
                Console.Write(a);
            }

            // Als n minimaal 2 is, print de tweede stap met een comma ervoor
            if (n >= 2)
            {
                Console.Write(", " + b);
            }

            // Vanaf de 3e stap berekenen we de volgende getallen via een for-loop
            for (int i = 3; i <= n; i++)
            {
                int volgende = a + b;
                Console.Write(", " + volgende);

                // Schuif de getallen één positie op
                a = b;
                b = volgende;
            }

            Console.WriteLine(); // Zorgt voor een nette afsluiting van de regel
        }
    }
}