using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Flyweight.Structural
{
    public class FlyweightFactoryTest
    {
        public void Test() {
            Console.WriteLine();

            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyWeight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyWeight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyWeight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
        }
    }
}
