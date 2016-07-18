using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Proxy.Structural
{
    public class ProxyTest
    {
        public void Test()
        {
            Console.WriteLine();

            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
