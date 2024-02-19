using AsciiAdventureImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AsciiAdventure
{
    public class Action1Choice2
    {
        public void Choice2() 
        {
            AsciiImages images = new AsciiImages();

            Console.WriteLine(images.cityArt);
            Console.WriteLine("\n\nYou get in your car and start driving to target...\n\n");

            Console.WriteLine(images.targetArt);
            Console.WriteLine("Prompt: When you get to target you notice no parking. Do you:\n(1) continue to circle around and find parking\n" +
                "(2) go home and get back in the ship.");

        }
    }
}
