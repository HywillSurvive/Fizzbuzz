namespace fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        // Créez une application console qui affiche tous les nombres de 1 à 100 inclus, à l’exception de certains nombres.
        // Tous les nombres divisibles par 3 seront remplacés par le mot “Fizz”.
        // Tous les nombres divisibles par 5 seront remplacés par le mot “Buzz”.
        // Tous les nombres qui sont divisibles à la fois par 3 et à la fois par 5 seront remplacés par le mot “FizzBuzz”.


        string fizz = "Fizz";
        string buzz = "Buzz";
        string fizzbuzz = "FizzBuzz";
        string final = "";

        Console.WriteLine("=====FizzBuzz=====");

        for (int nombre = 1; nombre < 101; nombre++)
        {
  
            if (nombre % 3 == 0)
            {
                
                if (nombre % 5 == 0)
                {
                    final = (nombre % 3 == 0) ? "FizzBuzz" : nombre.ToString();
                    //Console.WriteLine("|  FizzBuzz  |");
                }

                else
                {
                    final = (nombre % 3 == 0) ? "Fizz" : nombre.ToString();
                    //Console.WriteLine("|  Fizz  |");
                }
               
            }

            if (nombre % 5 == 0)
            {
                
                if (nombre % 3 == 0)
                {
                    final = (nombre % 5 == 0) ? "FizzBuzz" : nombre.ToString();
                    //Console.WriteLine("|  FizzBuzz  |");
                }

                else
                {
                    final = (nombre % 5 == 0) ? "Buzz" : nombre.ToString();
                    //Console.WriteLine("|  Buzz  |");
                }
               
            }

            if(nombre % 3 != 0 && nombre % 5 != 0)
            {
                 final = nombre.ToString();
                //Console.WriteLine(nombre);
            }

            Console.Write("  |  " + final);

            if (nombre % 10 == 0)
            {
                Console.WriteLine();
            }

        }
    }
}