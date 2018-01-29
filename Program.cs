using System;
using System.Text;
using System.Linq;

namespace NickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] nicknames = new string [10,2];

            
            nicknames[0,0] = "Violent";
            nicknames[0,1] = "Magician";

            nicknames[1,0] = "Dynamic";
            nicknames[1,1] = "Worlock";

            nicknames[2,0] = "Tuff";
            nicknames[2,1] = "Overlord";

            nicknames[3,0] = "Amatuer";
            nicknames[3,1] = "Wanderer";
            
            nicknames[4,0] = "Foolish";
            nicknames[4,1] = "Mastermind";
            
            nicknames[5,0] = "Tha";
            nicknames[5,1] = "Professional";

            nicknames[6,0] = "Phantom";
            nicknames[6,1] = "Madman";

            nicknames[7,0] = "Gentlemen";
            nicknames[7,1] = "Menace";

            nicknames[8,0] = "Violent";
            nicknames[8,1] = "Leader";

            nicknames[9,0] = "Vulgar";
            nicknames[9,1] = "Bandit";


            Console.WriteLine("Hi, please give me your name");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");


            Console.WriteLine("Did you know your name reversed is: {0}?", reverser(name));
        
            Console.WriteLine("And your name is this long in characters: {0}", name.Length);
            
            string[] parts = name.Split(new char[]{' '});
            
            Console.WriteLine("Nickname first name is {0}", getNickNameComponent(parts[0], nicknames, "first"));

            Console.WriteLine("Nickname last name is {0}", getNickNameComponent(parts[1], nicknames, "last"));

        }


        public static string getNickNameComponent(string input, string[,] nicknames, string position)
        {
            string output = "";
            
            int index = input.Length % nicknames.GetLength(0);

            switch(position)
            {
                case "first":
                    output = nicknames[index, 0];
                    break;
                case "last":
                    output = nicknames[index , 1];
                    break;
                default:
                    output = "Wrong";
                    break;

            }


            return output;;
        }

        public static string reverser(string original)
        {

            char[] temp = original.ToCharArray();

            for(int i = 0; i<temp.Length; i++)
            {
                Console.WriteLine("{0}", temp[i]);
            }

            Array.Reverse(temp);

            Console.WriteLine(temp);

            string output = new string (temp);

            Console.WriteLine(output);

            return output;
        }
    }
}
