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
            int totalLikes = 0;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (answer == "")
                {
                    Console.WriteLine("Display: ");
                    break;
                }
                else if(facebookLikes.Count == 0)
                {
                    facebookLikes.Add(answer);

                    foreach (var like in facebookLikes)
                    {
                        Console.WriteLine(like + " Likes your post");
                        break;
                    }

                }
                else if(facebookLikes.Count == 1)
                {
                    facebookLikes.Add(answer);

                    foreach (var like in facebookLikes)
                    {
                        Console.WriteLine(facebookLikes[0] + " and " + facebookLikes[1]  + " Like your post");
                        break;
                    }

                    ++totalLikes;
                }
                else if (facebookLikes.Count > 1)
                {
                    facebookLikes.Add(answer);

                    foreach (var like in facebookLikes)
                    {
                        Console.WriteLine(facebookLikes[0] + " , " + facebookLikes[1] + " and " + totalLikes + " others like your post");
                        break;
                    }

                    ++totalLikes;
                }
            }
            while (answer != "exit");

            
            

        }
    }
}
