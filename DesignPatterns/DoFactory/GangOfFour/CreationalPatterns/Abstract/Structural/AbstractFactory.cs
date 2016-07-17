using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Abstract.Structural
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractFactoryB CreateProductB();

    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractFactoryB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractFactoryB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public abstract class AbstractFactoryB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public abstract class AbstractProductA
    {
    }

    public class ProductA1 : AbstractProductA
    {
    }

    public class ProductB1 : AbstractFactoryB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {
    }

    public class ProductB2 : AbstractFactoryB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }

    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractFactoryB _abstractProductB;

        public Client(AbstractFactory abstractFactory)
        {
            _abstractProductA = abstractFactory.CreateProductA();
            _abstractProductB = abstractFactory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }

}
