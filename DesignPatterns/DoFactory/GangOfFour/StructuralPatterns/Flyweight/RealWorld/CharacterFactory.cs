using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Flyweight.RealWorld
{
    class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;
            if (_characters.ContainsKey(key))
                character = _characters[key];
            else
            {
                switch (key)
                {
                    case 'A':
                        character = new CharacterA();
                        break;
                    case 'B':
                        character = new CharacterB();
                        break;
                    case 'Z':
                        character = new CharacterZ();
                        break;
                }
                _characters.Add(key, character);
            }



            return character;
        }
    }

    internal abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public abstract void Display(int pointSize);
    }

    internal class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 100;
            this.ascent = 68;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }

    internal class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }

    internal class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }

}
