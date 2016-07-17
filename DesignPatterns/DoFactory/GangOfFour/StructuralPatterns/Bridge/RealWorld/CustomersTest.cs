using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.RealWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.RealWorld
{
    public class CustomersTest
    {
        public void Test()
        {
            Customers customers = new Customers("Chicago");

            customers.DataObject = new CustomersData();

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

        }
    }
}
