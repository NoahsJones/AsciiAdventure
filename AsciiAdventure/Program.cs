using AsciiAdventureImages;



namespace AsciiAdventure
{
    public class ChooseYourOwnAdventure
    {
        static void Main(string[] args)
        {
            //Below are my object instances >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            AsciiImages images = new AsciiImages();
            Action1Choice1 action1Choice1 = new Action1Choice1();
            Action1Choice2 action1Choice2 = new Action1Choice2();
            Action2Choice1 action2Choice1 = new Action2Choice1();
            Action2Choice2 action2Choice2 = new Action2Choice2();
            Action3Choice1 action3Choice1 = new Action3Choice1();
            Action3Choice2 action3Choice2 = new Action3Choice2();
            Action4Choice1 action4Choice1 = new Action4Choice1();
            //testagain
            //Above are my object instances ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("\n\n\nDo you want to play a game? yes(y) or no(n)?");

                string play = Console.ReadLine();

                if (play == "y")
                {
                    Console.WriteLine("Hello and welcome to the ASCII Art Space Adventure!\nHere you will be asked to input what actions you want your character to perform. Either input 1 or 2");
                    Console.WriteLine("\nBackstory: You are a farmer in Kansas city out on your ranch. You recently just finished astronaut school and \nengineering school." +
                        " You live alone and want to see if the outside worlds are as alone as you are...\n\n");
                    Console.WriteLine("Prompt: You are sitting at your house right now do you:\n(1) want to go to your rocketship and get in?\n(2) go to target?");
                    Console.WriteLine(images.rocketShipAndHouseArt);

                    string action1 = Console.ReadLine();//1.0 ACTION

                    if (action1 == "1")//CONTINUE
                    {
                        action1Choice1.Choice1();
                        string action3 = Console.ReadLine();//1.1 ACTION

                        if (action3 == "1")//CONTINUE
                        {
                            action3Choice1.Choice1();
                            string action4 = Console.ReadLine();

                            if (action4 == "1")//CONTINUE
                            {
                                action4Choice1.Choice1();
                                string action6 = Console.ReadLine();
                            }
                            else if (action4 == "2")//CONTINUE
                            {
                                Console.WriteLine(images.earthArt);
                                Console.WriteLine("You are headed away from earth into the great abyss of space...");

                                string action7 = Console.ReadLine();
                            }
                        }
                        else if (action3 == "2")//END
                        {
                            action3Choice2.Choice2();
                        }

                    }
                    else if (action1 == "2")//CONTINUE
                    {
                        action1Choice2.Choice2();
                        string action2 = Console.ReadLine();//1.2 ACTION

                        if (action2 == "1")//END
                        {
                            action2Choice1.Choice1();
                        }
                        else if (action2 == "2")//CONTINUE
                        {
                            action2Choice2.Choice2();

                            string action5 = Console.ReadLine();

                            if (action5 == "1")//CONTINUE
                            {

                            }
                            else if (action5 == "2")//END
                            {

                            }
                        }
                    }
                }
                else
                {
                    keepPlaying = false;
                }

                    //Above is the game ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            }

        }

    }
}
