using AsciiAdventureImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiAdventure
{
    public class Action4Choice1
    {
        public void Choice1()
        {
            AsciiImages images = new AsciiImages();
            Console.WriteLine(images.rocketShipMidSpaceArt);
            Console.WriteLine("You are headed towards the moon...");
        }
    }
}
