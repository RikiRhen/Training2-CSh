using System.Text.RegularExpressions;

namespace Övning_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while(running)
            {
                
                Console.Write("Välkommen till huvudmenyn.\n" +
                    "Vänligen använd de nummer som finns vid rubrikerna för att navigera i menyn!\n" +
                    "1. Ungdom eller Pensionär? - Ska personen betala normalpris, ungdomspris eller pensionärspris?\n" +
                    "2. Kostnad för gruppbio - Räkna ut kostnaden för flera biljetter.\n" +
                    "3. Upprepa 10 gånger - Repeterar din inmatning 10 gånger på en rad.\n" +
                    "4. Det tredje ordet - Printa ut det tredje ordet i den mening som du skrev in.\n" +
                    "0. Avsluta programmet.\n" +
                    "> ");
                string switchChoice = Console.ReadLine()!;
                
                switch (switchChoice)
                {
                    case "1":
                        //Case 1 - Ta input, parsea om till integer, printa ut text beroende på värdet av integern
                        int age = Helper.TakeInputInteger("\nÅlder? >");

                        //Printa ut olika priser baserat på åldern, Gratis för under 5 och pensionärer över 100, 5-19 Ungdomspris: 80kr, över 64 Pensionärspris: 90kr, Standardpris 120kr. 
                        Console.WriteLine(Helper.CheckAgeGroup(age));
                        break;

                    case "2":
                        //Case 2 - Räkna ihop totalkostnaden av en grupp
                        int totalCost = 0;
                        List<int> groupAges = new List<int>();
                        
                        int groupSize = Helper.TakeInputInteger("\nHur många är det i gruppen?");
                        //Säkerställ att gruppen är faktiskt fler än 1.
                        while (groupSize < 2)
                        {
                            groupSize = Helper.TakeInputInteger("\nEn grupp måste vara 2 eller fler");
                        }
                        

                        //Samla ihop samtliga åldrar i gruppen till en lista.
                        for (int i = 0; i < groupSize; i++)
                        {
                            groupAges.Add(Helper.TakeInputInteger("Ålder på gruppmedlem nummer " + (i + 1) + "?"));
                        }

                        //Iterera igenom listan och sätt ihop totalkostnaden.
                        foreach (int i in groupAges)
                        {
                            totalCost += Helper.CalculatePrice(i);
                        }

                        //Presentera kostnad.
                        Console.WriteLine("Totala kostnaden för gruppen är: " + totalCost + "kr.\n");                        
                        break;

                    case "3":
                        //Case 3 - Printa ut input 10 gånger på samma rad.
                        string repeat = "";
                        string case3Input = Helper.TakeInputString("Vad vill du ha repeterat? >");

                        //Konkatinera in case3Input till repeat 10 gånger.
                        for (int i = 0; i < 10; i++)
                        {
                            repeat += case3Input + ", ";
                        }

                        //Presentera resultat.
                        Console.WriteLine(repeat);

                        break;

                    case "4":
                        //Case 4 - Input är en mening på minst 3 ord. Printa ut det tredje ordet.
                        string case4Input = Helper.TakeInputString("Skriv in en mening på minst 3 ord. >");
                        //Rensa ut överflödiga mellanslag.
                        Regex.Replace(case4Input.Trim(), @"\s+", " ");
                        //Skapa arrayn med samtliga ord som egna element.
                        string[] words = case4Input.Split(' ');

                        //Presentera det tredje ordet.
                        Console.WriteLine("\nDet tredje ordet är: " + words[2]);
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
