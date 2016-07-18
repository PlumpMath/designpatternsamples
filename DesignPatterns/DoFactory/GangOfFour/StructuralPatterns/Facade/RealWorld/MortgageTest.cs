using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Facade.RealWorld
{
    public class MortgageTest
    {
        public void Test()
        {

            Console.WriteLine();
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer("Ann Mckinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
