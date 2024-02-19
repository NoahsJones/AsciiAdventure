using AsciiAdventureImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiAdventure
{
    public class Action2Choice1
    {
        public void Choice1() 
        {
            AsciiImages images = new AsciiImages();
            Console.WriteLine(images.explosionArt);
            Console.WriteLine("Your car was remotely exploded by the cartel who placed a bomb on the car while your were still driving around...\n\nYOU LOSE!");

        }



    }
}
