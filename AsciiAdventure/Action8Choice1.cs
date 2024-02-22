using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsciiAdventureImages;

namespace AsciiAdventure
{
    public class Action8Choice1
    {
        public void Choice1()
        {
            AsciiImages images = new AsciiImages();
            Console.WriteLine(images.startingPointArt);
            Console.WriteLine("Whoa you have a major problem with the projector! It is way off course.");
            Console.WriteLine("Prompt: do you:\n(1) try and fix the problem\n(2) ignore the problem");
        }
    }
}
