using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            var prompt = "Please enter the names that liked your Facebook Post:";
            var facebookLikes = new List<string>();


            Console.WriteLine(prompt);
            var answer = Console.ReadLine();

            while(answer != "exit")
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (answer == "")
                {
                    Console.WriteLine("Display: ");
                }
                else
                {
                    facebookLikes.Add(answer);

                    foreach (var like in facebookLikes)
                    {
                        Console.WriteLine("In your list: " + like);
                    }

                }
            }

            
            

        }
    }
}
