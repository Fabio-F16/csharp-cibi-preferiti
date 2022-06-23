namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] cibiPreferiti = { "Lasagne", "Pizza", "Sushi", "McDonalds", "Kebab", "Gelato", "Risotto", "Minestrone" };




            Console.WriteLine("La lunghezza dei miei piatti preferiti è " + cibiPreferiti.Length);

            Console.WriteLine("Il mio miglior piatto preferito è " + cibiPreferiti[0]);

            Console.WriteLine("Il mio peggior piatto preferito è " + cibiPreferiti[cibiPreferiti.Length - 1]);

           // Console.WriteLine("Inserisci il tuo cibo preferito:");
           // string userFood = Console.ReadLine();
           string userFood = "";
            bool exist = true;
            do
            {

                Console.WriteLine("Inserisci il tuo cibo preferito:");
                userFood = Console.ReadLine();
                for (int i = 0; i < cibiPreferiti.Length; i++)
                {
                    if(userFood == cibiPreferiti[i])
                    {
                        exist = false;
                    }
                    
                }
                
            } while (exist);
         


            int foodLength = cibiPreferiti.Length;
            Random rnd = new Random();
            int randomNumber = rnd.Next(foodLength);

            Console.WriteLine("numero random cpu " + randomNumber);
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                var foodCpu = cibiPreferiti[randomNumber-1];
                if(cibiPreferiti[i] == userFood && cibiPreferiti[i] == foodCpu)
                {
                    Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " -> è il piatto preferito di entrambi");
                   // Console.WriteLine((i + 1) + " " + cibiPreferiti[i]);
                }
                else if(cibiPreferiti[i] == userFood)
                {
                    Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " -> è il piatto preferito dell'utente");
                }
                else if(cibiPreferiti[i] == foodCpu)
                {
                    Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " -> è il piatto preferito del computer");
                   // Console.WriteLine((i + 1) + " " + cibiPreferiti[i]);
                }
                else
                {
                    Console.WriteLine((i + 1) + " " + cibiPreferiti[i]);
                }
               
            }

     

        
        

        }
    }
}