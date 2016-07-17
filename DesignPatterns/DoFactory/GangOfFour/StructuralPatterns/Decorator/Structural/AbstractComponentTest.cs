using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Decorator.Structural
{
    public class AbstractComponentTest
    {
        public void Test()
        {
            Console.WriteLine();

            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();
        }
    }
}
