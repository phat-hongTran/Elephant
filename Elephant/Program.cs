using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            while (true)
            {
                char keyPress = Console.ReadKey(true).KeyChar;

                Console.WriteLine("You pressed " + keyPress);
                switch (keyPress)
                {
                    case '1':
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                        break;
                    case '2':
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                        break;
                    case '3':
                        Console.WriteLine("References have been swapped");
                        Elephant temp = lucinda;
                        lucinda = lloyd;
                        lloyd = temp;
                        break;
                    case '4':
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                        break;
                    case '5':
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                        break;
                    default:
                        continue;
                }

                Console.WriteLine();
            }
        }
    }
}
