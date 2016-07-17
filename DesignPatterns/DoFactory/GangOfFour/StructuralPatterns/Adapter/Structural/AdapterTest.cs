using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Adapter.Structural
{
    public class AdapterTest
    {
        public void Test()
        {
            Console.WriteLine();
            Target target = new Adapter();
            target.Request();

        }

        
    }
}
