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
            var answer = "";

            Console.WriteLine(prompt);
            answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine("Display: ");
            }else
            {
                Console.WriteLine("Display: " + answer + " Likes your post");
            }
            

        }
    }
}
