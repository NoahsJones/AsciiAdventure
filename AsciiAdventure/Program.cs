
namespace AsciiAdventure
{
    internal class ChooseYourOwnAdventure
    {


        static void Main(string[] args)
        {

            //These are my ASCII art variables below
            string earthArt = @"         
        _____
    ,-:` \;',`'-, 
  .'-;_,;  ':-;_,'.
 /;   '/    ,  _`.-\
| '`. (`     /` ` \`|
|:.  `\`-.   \_   / |
|     (   `,  .`\ ;'|
 \     | .'     `-'/
  `.   ;/        .'
    `'-._____.
";

            string otherPlanetArt = @"
    ~+

                 *       +
           '                  |
       ()    .-.,=""``""=.    - o -
             '=/_       \     |
          *   |  '=._    |
               \     `=./`,        '
            .   '=.__.=' `='      *
   +                         +
        O      *        '       .
";

            string startingPointArt = @"

 .              +   .                .   . .     .  .
                   .                    .       .     *
  .       *                        . . . .  .   .  + .
            ""You Are Here""            .   .  +  . . .
.                 |             .  .   .    .    . .
                  |           .     .     . +.    +  .
                 \|/            .       .   . .
        . .       V          .    * . . .  .  +   .
           +      .           .   .      +
                            .       . +  .+. .
  .                      .     . + .  . .     .      .
           .      .    .     . .   . . .        ! /
      *             .    . .  +    .  .       - O -
          .     .    .  +   . .  *  .       . / |
               . + .  .  .  .. +  .
.      .  .  .  *   .  *  . +..  .            *
 .      .   . .   .   .   . .  +   .    .            +

";

            string solarSystemArt = @"

 .      .      .      .      .      .      .      .      .      .      .
.                               .       .       .       .       .       .
   .        .        .        .        .        .        .        .        .
     .         .         .        _......____._        .         .
   .          .          . ..--'"""" .           """"""""""""---...          .
                   _...--""""        ................       `-.              .
                .-'        ...:'::::;:::%:.::::::_;;:...     `-.
             .-'       ..::::'''''   _...---'"""""""":::+;_::.      `.      .
  .        .' .    ..::::'      _.-""""               :::)::.       `.
         .      ..;:::'     _.-'         .             f::'::    o  _
        /     .:::%'  .  .-""                        .-.  ::;;:.   /"" ""x
  .   .'  """"::.::'    .-""     _.--'""""""-.           (   )  ::.::  |_.-' |
     .'    ::;:'    .'     .-"" .d@@b.   \    .    . `-'   ::%::   \_ _/    .
    .'    :,::'    /   . _'    8@@@@8   j      .-'       :::::      "" o
    | .  :.%:' .  j     (_)    `@@@P'  .'   .-""         ::.::    .  f
    |    ::::     (        -..____...-'  .-""          .::::'       /
.   |    `:`::    `.                ..--'        .  .::'::   .    /
    j     `:::::    `-._____...---""""             .::%:::'       .'  .
     \      ::.:%..             .       .    ...:,::::'       .'
 .    \       `:::`:..                ....::::.::::'       .-'          .
       \    .   ``:::%::`::.......:::::%::.::::''       .-'
      . `.        . ``::::::%::::.::;;:::::'''      _.-'          .
  .       `-..     .    .   ````'''''         . _.-'     .          .
         .    """"--...____    .   ______......--' .         .         .
  .        .        .    """"""""""""""""     .        .        .        .        .
 .       .       .       .       .       .       .       .       .
     .      .      .      .      .      .      .      .      .      .      .

";

            string loseArt = @"

o
 \_/\o
( Oo)                    \|/
(_=-)  .===O-  ~~Z~A~P~~ -O-
/   \_/U'                /|\
||  |_/
\\  |
{K ||
 | PP
 | ||
 (__\\

";

            string alienFriendArt = @"

    _____
 ___/     \___
`-._)     (_,-`
    \O _ O/
     \ - /
      `-(
       ||
      _||_
     |-..-|
     |/. \|
     |\__/|
   ._|//\\|_,
   `-((  ))-'
    __\\//__ 
    >_ /\ _<,
      ''

";

            string rocketShipBeforeLaunchArt = @"

           ___
     |     | |
    / \    | |
   |--o|===|-|
   |---|   |d|
  /     \  |w|
 | U     | |b|
 | S     |=| |
 | A     | | |
 |_______| |_|
  |@| |@|  | |
___________|_|_

";

            string rocketShipAndHouseArt = @"

         *                 *                  *              *
                                                      *             *
                        *            *                             ___
  *               *                                          |     | |
        *              _________##                 *        / \    | |
                      @\\\\\\\\\##    *     |              |--o|===|-|
  *                  @@@\\\\\\\\##\       \|/|/            |---|   |d|
                    @@ @@\\\\\\\\\\\    \|\\|//|/     *   /     \  |w|
             *     @@@@@@@\\\\\\\\\\\    \|\|/|/         |  U    | |b|
                  @@@@@@@@@----------|    \\|//          |  S    |=| |
       __         @@ @@@ @@__________|     \|/           |  A    | | |
  ____|_@|_       @@@@@@@@@__________|     \|/           |_______| |_|
=|__ _____ |=     @@@@ .@@@__________|      |             |@| |@|  | |
____0_____0__\|/__@@@@__@@@__________|_\|/__|___\|/__\|/___________|_|_

";

            string rocketShipAtLaunchArt = @"

    /\
   /  \
  |    |
  |NASA|
  |    |
  |    |
  |    |
 '      `
 |      |
 |      |
 |______|
  '-`'-`   .
  / . \'\ . .'
 ''( .'\.' ' .;'
'.;.;' ;'.;' ..;;' 

";

            string rocketShipMidFlightArt = @"

                                       _,'/
                                  _.-''._:
                          ,-:`-.-'    .:.|
                         ;-.''       .::.|
          _..------.._  / (:.       .:::.|
       ,'.   .. . .  .`/  : :.     .::::.|
     ,'. .    .  .   ./    \ ::. .::::::.|
   ,'. .  .    .   . /      `.,,::::::::.;\
  /  .            . /       ,',';_::::::,:_:
 / . .  .   .      /      ,',','::`--'':;._;
: .             . /     ,',',':::::::_:'_,'
|..  .   .   .   /    ,',','::::::_:'_,'
|.              /,-. /,',':::::_:'_,'
| ..    .    . /) /-:/,'::::_:',-'
: . .     .   // / ,'):::_:',' ;
 \ .   .     // /,' /,-.','  ./
  \ . .  `::./,// ,'' ,'   . /
   `. .   . `;;;,/_.'' . . ,'
    ,`. .   :;;' `:.  .  ,'
   /   `-._,'  ..  ` _.-'
  (     _,'``------''  SSt
   `--''

";

            string rocketShipMidSpaceArt = @"

                        .-.
                        ( (
                         `-'






                    .   ,- To the Moon Alice !
                   .'.
                   |o|
                  .'o'.
                  |.-.|
                  '   '
                   ( )
                    )
                   ( )

               ____
          .-'""""p 8o""""`-.
       .-'8888P'Y.`Y[ ' `-.
     ,']88888b.J8oo_      '`.
   ,' ,88888888888[""        Y`.
  /   8888888888P            Y8\
 /    Y8888888P'             ]88\
:     `Y88'   P              `888:
:       Y8.oP '- >            Y88:
|          `Yb  __             `'|
:            `'d8888bo.          :
:             d88888888ooo.      ;
 \            Y88888888888P     /
  \            `Y88888888P     /
   `.            d88888P'    ,'
     `.          888PP'    ,'
       `-.      d8P'    ,-'   -CJ-
          `-.,,_'__,,.-'

";

            string moonLanderArt = @"

                     _  _     ____________.--.
                  |\|_|//_.-"""" .'    \   /|  |
                  |.-""""""-.|   /       \_/ |  |
                  \  ||  /| __\_____________ |
                  _\_||_/_| .-""""            """"-.  __
                .' '.    \//                    "".\/
                ||   '. >()_                     |()<
                ||__.-' |/\ \                    |/\
                   |   / ""|  \__________________/.""""
                  /   //  | / \ ""-.__________/  /\
               ___|__/_|__|/___\___"".______//__/__\
              /|\     [____________] \__/         |\
             //\ \     |  |=====| |   /\\         |\\
            // |\ \    |  |=====| |   | \\        | \\        ____...____....----
          .//__| \ \   |  |=====| |   | |\\       |--\\---""""""""     .            ..
_____....-//___|  \_\  |  |=====| |   |_|_\\      |___\\    .                 ...'
 .      .//-.__|_______|__|_____|_|_____[__\\_____|__.-\\      .     .    ...::
        //        //        /          \ `-_\\/         \\          .....:::
  -... //     .  / /       /____________\    \\       .  \ \     .            .
      //   .. .-/_/-.                 .       \\        .-\_\-.                 .
     / /      '-----'           .             \ \      '._____.'         .
  .-/_/-.         .                          .-\_\-.                          ...
 '._____.'                            .     '._____.'                       .....
        .                                                             ...... ..
    .            .                  .                        .
   ...                    .                      .                       .      .
        ....     .                       .                    ....
          ......           . ..                       ......'
             .......             '...              ....
                                   ''''''      .              .

";

            string astronautArt = @"

        _..._
      .'     '.      _
     /    .-""-\   _/ \
   .-|   /:.   |  |   |
   |  \  |:.   /.-'-./
   | .-'-;:__.'    =/
   .'=  *=|NASA _.='
  /   _.  |    ;
 ;-.-'|    \   |
/   | \    _\  _\
\__/'._;.  ==' ==\
         \    \   |
         /    /   /
         /-._/-._/
         \   `\  \
          `-._/._/

";

            string winArt = @"

                      <>
        .-""""""-.       ||::::::==========
       /= ___  \      ||::::::==========
      |- /~~~\  |     ||::::::==========
      |=( '.' ) |     ||================
      \__\_=_/__/     ||================
       {_______}      ||================
     /` *       `'--._||
    /= .     [] .     { >
   /  /|ooo     |`'--'|| 
  (   )\_______/      ||
   \``\/       \      ||
    `-| ==    \_|     ||
      /         |     ||
     |=   >\  __/     ||
     \   \ |- --|     ||
      \ __| \___/     ||
 jgs  _{__} _{__}     ||
     (    )(    )     ||
 ^^~  `""""""  `""""""  ~^^^~^^~~~^^^~^^^~^^^~^^~^

";

            string cityArt = @"

                       .|
                       | |
                       |'|            ._____
               ___    |  |            |.   |' .---""|
       _    .-'   '-. |  |     .--'|  ||   | _|    |
    .-'|  _.|  |    ||   '-__  |   |  |    ||      |
    |' | |.    |    ||       | |   |  |    ||      |
 ___|  '-'     '    """"       '-'   '-.'    '`      |____
jgs~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

";

            string targetArt = @"

.             .        .     .     |--|--|--|--|--|--|  |===|==|   /    i
        .            ______________|__|__|__|__|__|_ |  |===|==|  *  . /=\
__ *            .   /______________________________|-|  |===|==|       |=|  .
__|  .      .   .  //______________________________| :----------------------.
__|   /|\      _|_|//       ooooooooooooooooooooo  |-|                      |
__|  |/|\|__   ||l|/,-------8                   8 -| |                      |
__|._|/|\|||.l |[=|/,-------8                   8 -|-|     Target           |
__|[+|-|-||||li|[=|---------8                   8 -| |                      |
_-----.|/| //:\_[=|\`-------8                   8 -|-|                      |
 /|  /||//8/ :  8_|\`------ 8ooooooooooooooooooo8 -| |                      |
/=| //||/ |  .  | |\\_____________  ____  _________|-|                      |
==|//||  /   .   \ \\_____________ |X|  | _________| `---==------------==---'
==| ||  /         \ \_____________ |X| \| _________|     ||            ||
==| |~ /     .     \
LS|/  /             \______________________________________________________

";

            string explosionArt = @"

          _ ._  _ , _ ._
        (_ ' ( `  )_  .__)
      ( (  (    )   `)  ) _)
     (__ (_   (_ . _) _) ,__)
         `~~`\ ' . /`~~`
              ;   ;
              /   \
_____________/_ __ \_____________

";

            //These are my ASCII art variables above ^^^^^^^^^^^^^^^^^^^^^^^^^

            //Below is the game

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("Do you want to play a game? yes(y) or no(n)?");

                string play = Console.ReadLine();

                if (play == "y")
                {
                    Console.WriteLine("Hello and welcome to the ASCII Art Space Adventure!\nHere you will be asked to input what actions you want your character to perform. Either input 1 or 2");
                    Console.WriteLine("\nBackstory: You are a farmer in Kansas city out on your ranch. You recently just finished astronaut school and \nengineering school." +
                        " You live alone and want to see if the outside worlds are as alone as you are...\n\n");
                    Console.WriteLine("Prompt: You are sitting at your house right now do you:\n(1) want to go to your rocketship and get in?\n(2) go to target?");
                    Console.WriteLine(rocketShipAndHouseArt);

                    string action1 = Console.ReadLine();//1.0 ACTION

                    if (action1 == "1")//CONTINUE
                    {
                        Console.WriteLine(rocketShipBeforeLaunchArt);
                        Console.WriteLine("\n\nYou make your way to the rocket ship and turn it on...");

                        Console.WriteLine("\nPrompt: You start to fly and mid fight you notice something wrong. Do you:\n(1) fix it\n(2) ignore it");

                        string action3 = Console.ReadLine();//1.1 ACTION

                        if (action3 == "1")//CONTINUE
                        {
                            Console.WriteLine(rocketShipMidFlightArt);
                            Console.WriteLine("You carry on flying as normal...");

                            Console.WriteLine("Prompt: You get out into space, do you:\n(1) fly away from earth\n(2) fly to the moon");

                            string action4 = Console.ReadLine();

                            if (action4 == "1")//CONTINUE
                            {
                                Console.WriteLine(rocketShipMidSpaceArt);
                                Console.WriteLine("You are headed towards the moon...");
                            }
                            else if (action4 == "2")//CONTINUE
                            {
                                Console.WriteLine(earthArt);
                                Console.WriteLine("You are headed away from earth into the great abyss of space...");
                            }
                        }
                        else if (action3 == "2")//END
                        {
                            Console.WriteLine(explosionArt);
                            Console.WriteLine("You ignored the problem and now the problem deleted you...\n\nYOU LOSE!");
                        }

                    }
                    else if (action1 == "2")//CONTINUE
                    {
                        Console.WriteLine(cityArt);
                        Console.WriteLine("\n\nYou get in your car and start driving to target...\n\n");

                        Console.WriteLine(targetArt);
                        Console.WriteLine("Prompt: When you get to target you notice no parking. Do you:\n(1) continue to circle around and find parking\n" +
                            "(2) go home and get back in the ship.");

                        string action2 = Console.ReadLine();//1.2 ACTION

                        if (action2 == "1")//END
                        {
                            Console.WriteLine(explosionArt);
                            Console.WriteLine("Your car was remotely exploded by the cartel who placed a bomb on the car while your were still driving around...\n\nYOU LOSE!");
                        }
                        else if (action2 == "2")//CONTINUE
                        {
                            Console.WriteLine(rocketShipBeforeLaunchArt);
                            Console.WriteLine("You get in your rocket ship and prepare for launch...");
                            

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

        //THIS IS A TEST FOR A MERGE AND PULL

        //THIS IS JUST A TEST FOR A COMMIT 
    }
}
