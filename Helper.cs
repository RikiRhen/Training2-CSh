using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
    [assembly:InternalsVisibleTo("Tester-Övning2")]
namespace Övning_2_C_
{
    /// <summary>
    /// Returnerar ReadLine inputs efter säkerställning att fältet inte lämnats tom.
    /// Parametern som skickas med är prompten du vill att användaren får utskriven till sig inför input eller heltalet som man vill registrera som ålder.
    /// </summary>
    internal class Helper
    {
        /// <summary>
        /// Tar en sträng som parameter, denna sträng printas ut till användaren. Returnerar en sträng tillbaka efter kontroller om giltighet.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static string TakeInputString(string prompt)
        {
            string result;
            Console.WriteLine(prompt);
            do 
            {                
                result = Console.ReadLine()!;
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Fältet kan inte lämnas tom, vänligen försök igen.");
                }

                else if (string.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine("Fältet kan inte lämas tom, vänligen försök igen.");
                }
            } while (string.IsNullOrWhiteSpace(result));
            return result;
        }

        /// <summary>
        /// Tar en sträng som parameter, denna sträng printas ut till användaren. Returnerar ett heltal tillbaka efter kontroller om giltighet.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static int TakeInputInteger(string prompt)
        {
            int result;
            Console.WriteLine(prompt);
            
            do
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Ogiltig heltal, vänligen försök igen.");
                }
                if (result < 0)
                {
                    Console.WriteLine("Negativa tal inte tillåtna, vänligen försök igen.");
                }
            } while (result < 0);

            return result;
        }

        /// <summary>
        /// Räknar ut priset för en biljett baserat på ålder. Returnerar en int som är priset.
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static int CalculatePrice(int age)
        {
            if (age < 5 || age > 99)
            {
                return 0;
            }
            else if (age >= 5 && age < 20)
            {
                return 80;
            }
            else if (age > 64 && age < 100)
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }

        /// <summary>
        /// Kontrollerar vilken ålderskategori den inmatade åldern är i. Returnerar en sträng med kategori och pris.
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static string CheckAgeGroup(int age)
        {
            if (age < 5 || age > 99)
            {
                return "Gratis inträde!\n";
            }
            else if (age >= 5 && age < 20)
            {
                return "Ungdomspris: 80kr\n";
            }
            else if (age > 64 && age < 100)
            {
                return "Pensionärspris: 90kr\n";
            }
            else
            {
                return "Standardpris: 120kr\n";
            }
        }
    }
}
