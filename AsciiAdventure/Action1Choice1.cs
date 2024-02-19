using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AsciiAdventureImages;
using static System.Net.Mime.MediaTypeNames;

namespace AsciiAdventure
{
    public class Action1Choice1
    {
        public void Choice1()
        {
            AsciiImages images = new AsciiImages();

            Console.WriteLine(images.rocketShipBeforeLaunchArt);
            Console.WriteLine("\n\nYou make your way to the rocket ship and turn it on...");

            Console.WriteLine("\nPrompt: You start to fly and mid fight you notice something wrong. Do you:\n(1) fix it\n(2) ignore it");
        }


    }
}
