using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.Structural
{
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public abstract class Implementor
    {
        public abstract void Operation();
    }


    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
