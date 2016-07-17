using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Adapter.Structural
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    public class Adapter : Target {
        private Adaptee _adaptee = new Adaptee();

        public override void Request() {
            _adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public Adaptee()
        {
        }

        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
