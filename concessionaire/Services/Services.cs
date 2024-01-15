using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire.Services
{
    public class Services
    {
        public static bool ValidatePurchase(double Personsalary, double carPrice)
        {
            var tenPerCentOfCarPrice = carPrice / 100 * 10;
            if (Personsalary * 3 < tenPerCentOfCarPrice)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static void CreateClient()
        {
            var client = Person.CreatePerson();
            Person.GetPerson(client);
        }
    }
}
