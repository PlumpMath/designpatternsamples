using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Prototype.RealWorld
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    public class Color : ColorPrototype
    {
        private int _blue;
        private int _green;
        private int _red;

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return (ColorPrototype)this.MemberwiseClone();
        }
    }

    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = 
            new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
