using AsciiAdventureImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiAdventure
{
    public class Action3Choice1
    {
        public void Choice1()
        {
            AsciiImages images = new AsciiImages();
            Console.WriteLine(images.rocketShipMidFlightArt);
            Console.WriteLine("You carry on flying as normal...");

            Console.WriteLine("Prompt: You get out into space, do you:\n(1) fly away from earth\n(2) fly to the moon");

        }
    }
}
