using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Composite.RealWorld
{
    public abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            this._name = name;
        }

        public abstract void Add(DrawingElement drawingElement);
        public abstract void Remove(DrawingElement drawingElement);
        public abstract void Display(int indent);
    }


    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            Console.WriteLine(
                "Cannot add to a PrimitiveElement");
        }
        public override void Remove(DrawingElement drawingElement)
        {
            Console.WriteLine(
              "Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + _name);
        }

    }

    public class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            elements.Add(drawingElement);
        }


        public override void Remove(DrawingElement drawingElement)
        {
            elements.Remove(drawingElement);
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
            "+ " + _name);

            foreach (DrawingElement d in elements)
                d.Display(indent + 2);
        }

    }
}
