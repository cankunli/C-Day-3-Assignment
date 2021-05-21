using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class HouseholdAccounts
    {
        public void House()
        {
            Console.WriteLine("Date (8 characters: YYYYMMDD format): ");
            string date = Console.ReadLine();

            Console.WriteLine("Description: ");
            string desc = Console.ReadLine();

            Console.WriteLine("Category: ");
            string cat = Console.ReadLine();

            Console.WriteLine("Amount (if positive income, negative if an expense): ");
            int amount = Convert.ToInt32(Console.ReadLine());
        }
    }
}
