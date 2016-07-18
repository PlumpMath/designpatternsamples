using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Flyweight.RealWorld
{
    public class CharacterFactoryTest
    {
        public void Test()
        {
            Console.WriteLine();

            string document = "AAZZBBZB";
            char[] chars = document.ToArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}
