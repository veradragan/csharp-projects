using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("SomeQuestions", "SometimesisreallyhardtocodeinC#");

            while (true)
            {
                 
                Console.WriteLine("In order to up-vote a post, type Up. To down-vote a post, type Down ");

                var input = Console.ReadLine().ToLower();
               
                if (input == "exit")
                    break;

                if (input == "up")
                {
                    post.UpVote();
                    Console.WriteLine(post.Vote);
                }
                else if (input == "down")
                {
                    post.DownVote();
                    Console.WriteLine(post.Vote);
                }
            }
        }
    }
}
