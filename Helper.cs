using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2_C_
{
    internal class Helper
    {
        /// <summary>
        /// Returnerar ReadLine input som en sträng efter säkerställning att fältet inte lämnats tom.
        /// Parametern som skickas med är prompten du vill att användaren får utskriven till sig inför input.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public string takeInputString(string prompt)
        {
            string result;
            Console.WriteLine(prompt);
            do 
            {                
                result = Console.ReadLine();

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

        public int takeInputInteger(string prompt)
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
    }
}
