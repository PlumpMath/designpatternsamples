using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.Structural
{
    public class FactoryTest
    {
        public void Test()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            Console.WriteLine("");

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
        }
    }
}
