namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] cibiPreferiti = { "Lasagne", "Pizza", "Sushi", "McDonalds", "Kebab", "Gelato", "Risotto", "Minestrone" };



            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(i + " " + cibiPreferiti[i]);
            }




            Console.WriteLine("La lunghezza dei miei piatti preferiti è " + cibiPreferiti.Length);

            Console.WriteLine("Il mio miglior piatto preferito è " + cibiPreferiti[0]);

            Console.WriteLine("Il mio peggior piatto preferito è " + cibiPreferiti[cibiPreferiti.Length - 1]);
        }
    }
}