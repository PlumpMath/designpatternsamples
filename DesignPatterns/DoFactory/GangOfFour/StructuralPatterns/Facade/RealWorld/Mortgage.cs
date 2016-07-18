using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Facade.RealWorld
{

    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }

    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }

    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }

    }

    class Customer
    {
        private string _name;


        public Customer(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            internal set { _name = value; }
        }
    }

    class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();


        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);
            bool eligible = true;

            if (!_bank.HasSufficientSavings(cust, amount))
                eligible = false;
            else if (!_loan.HasNoBadLoans(cust))
                eligible = false;
            else if (!_credit.HasGoodCredit(cust))
                eligible = false;

            return eligible;
        }
    }
}
