using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.Structural
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public abstract class Product { }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class ConcreteProductA : Product { }

    public class ConcreteProductB : Product { }

}
