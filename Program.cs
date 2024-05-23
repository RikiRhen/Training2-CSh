namespace Övning_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Helper helper = new();

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
                string switchChoice = Console.ReadLine();
                
                switch (switchChoice)
                {
                    //Testcase. Behöver ett case och pilla hjälpmetoder med.
                    /*
                    case "5":
                        string test1 = helper.takeInputString("Strängtest: >");
                        int test2 = helper.takeInputInteger("Integertest: >");
                        Console.WriteLine(test1 + ", " + test2);
                        break;
                    */
                    case "1":
                        //Case 1 - Ta input, parsea om till integer, printa ut text beroende på värdet av integern
                        int age = helper.takeInputInteger("\nÅlder? >");

                        //Printa ut olika priser baserat på åldern, Gratis för under 5 och pensionärer över 100, 5-19 Ungdomspris: 80kr, över 64 Pensionärspris: 90kr, Standardpris 120kr. 
                        Console.WriteLine(helper.checkAgeGroup(age));
                        break;

                    case "2":
                        //Case 2 - Räkna ihop totalkostnaden av en grupp
                        int groupSize = helper.takeInputInteger("\nHur många är det i gruppen?");
                        while (groupSize < 2)
                        {
                            groupSize = helper.takeInputInteger("\nEn grupp måste vara 2 eller fler");
                        }
                        int totalCost = 0;
                        List<int> groupAges = new List<int>();

                        //Samla ihop samtliga åldrar i gruppen till en lista.
                        for (int i = 0; i < groupSize; i++)
                        {
                            groupAges.Add(helper.takeInputInteger("Ålder på gruppmedlem nummer " + (i + 1) + "?"));
                        }

                        //Iterera igenom listan och sätt ihop totalkostnaden.
                        foreach (int i in groupAges)
                        {
                            totalCost += helper.calculatePrice(i);
                        }

                        
                        Console.WriteLine("Totala kostnaden för gruppen är: " + totalCost + "kr.\n");                        
                        break;

                    case "3":
                        //Case 3 - Printa ut input 10 gånger på samma rad.
                        string repeat = "";
                        string case3Input = helper.takeInputString("Vad vill du ha repeterat? >");

                        for (int i = 0; i < 10; i++)
                        {
                            repeat += case3Input + ", ";
                        }
                        Console.WriteLine(repeat);

                        break;
                    case "4":
                        //Case 4 - Input är en mening på minst 3 ord. Printa ut det tredje ordet.
                        string case4Input = helper.takeInputString("Skriv in en mening på minst 3 ord. >");
                        string[] words = case4Input.Split(' ');
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
