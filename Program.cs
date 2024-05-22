namespace Övning_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while(running)
            {
                Console.WriteLine("Välkommen till huvudmenyn.\n" +
                    "Vänligen använd de nummer som finns vid rubrikerna för att navigera i menyn!\n" +
                    "1. Ungdom eller Pensionär? - Ska personen betala normalpris, ungdomspris eller pensionärspris?\n" +
                    "2. Kostnad för gruppbio - Räkna ut kostnaden för flera biljetter.\n" +
                    "3. Upprepa 10 gånger - Repeterar din inmatning 10 gånger på en rad.\n" +
                    "4. Det tredje ordet - Printa ut det tredje ordet i den mening som du skrev in.\n" +
                    "0. Avsluta programmet.");
                string switchChoice = Console.ReadLine();
                
                switch (switchChoice)
                {
                    case "1":
                        //Case 1 - Ta input, parsea om till integer, printa ut text beroende på värdet av integern
                        int age;
                        do
                        {
                            //TODO: Säkerställa att åldern som anges är positiv. Fungerar ish nu men ser inte snyggt ut.

                            //Ta ålder, parsea om till integer. Fortsätt försöka tills en korrekt integer angivits.
                            Console.WriteLine("Vänligen ange ålder.");
                            while (!int.TryParse(Console.ReadLine(), out age))
                            {
                                Console.WriteLine("Ogiltig ålder, vänligen försök igen.");
                            }
                        } while (age < 0);

                        //Printa ut olika priser baserat på åldern, Gratis för under 5 och pensionärer över 100, 5-19 Ungdomspris: 80kr, över 64 Pensionärspris: 90kr, Standardpris 120kr. 
                        if (age < 5 || age > 99)
                        {
                            Console.WriteLine("Gratis inträde!\n");
                        }
                        else if (age >= 5 && age < 20)
                        {
                            Console.WriteLine("Ungdomspris: 80kr\n");
                        }
                        else if (age > 64 && age < 100)
                        {
                            Console.WriteLine("Pensionärspris: 90kr\n");
                        }
                        else
                        {
                            Console.WriteLine("Standardpris: 120kr\n");
                        }
                        
                        
                        

                        break;
                    case "2":
                        //Case 2 - Räkna ihop totalkostnaden av en grupp
                        Console.WriteLine("TODO");
                        break;
                    case "3":
                        //Case 3 - Printa ut input 10 gånger på samma rad.
                        Console.WriteLine("TODO");
                        break;
                    case "4":
                        //Case 4 - Input är en mening på minst 3 ord. Printa ut det tredje ordet.
                        Console.WriteLine("TODO");
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, vänligen försök igen.\n");
                        break;

                }
            }
        }
    }
}
