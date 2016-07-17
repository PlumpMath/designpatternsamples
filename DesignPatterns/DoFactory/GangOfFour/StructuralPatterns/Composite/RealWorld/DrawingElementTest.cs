using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Composite.RealWorld
{
    public class DrawingElementTest
    {

        public void Test()
        {
            Console.WriteLine();

            DrawingElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            DrawingElement comp = new CompositeElement("Two Circles");
            comp.Add(new CompositeElement("Black Circle"));
            comp.Add(new CompositeElement("White Circle"));
            root.Add(comp);

            DrawingElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);

            root.Display(1);
            
        }
    }
}
