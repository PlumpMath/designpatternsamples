using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Facade.Structural
{
    public class FacadeTest {

        public void Test()
        {

            Console.WriteLine();
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
    
}
