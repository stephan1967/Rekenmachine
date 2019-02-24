namespace Rekenmachine
{

    /*
      The main Math class
      Contains all methods for performing basic math functions
    */
    /// <summary>
    /// The main Math class.
    /// Contains all methods for performing basic math functions.
    /// </summary>


    public class Bereken
    {

        // Adds two integers and returns the result
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        public int Optellen (int a, int b)
        /// <summary>
        /// Met deze methode kun je 2 getallen bij elkaar optellen
        /// </summary>
        { return a + b; }


        public int Aftrekken(int a, int b)
        /// <summary>
        /// Met deze methode kun je 2 getallen van elkaar aftrekken
        /// </summary>
        { return a - b; }


        public int Delen(int a, int b)
        /// <summary>
        /// Met deze methode kun je 2 getallen door elkaar delen
        /// </summary>
        { return a / b; }


        public int Vermenigvuldigen(int a, int b)   { return a * b; }

    }
}
