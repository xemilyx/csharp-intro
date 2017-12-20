using System;
using System.Collections.Generic;

namespace PostExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //In the main method, create a post, 
            var post = new Post();

            Console.WriteLine("Type \"up\" to upvote or \"down\" to downvote. Type \"end\" to exit.");
            
            //up-vote and down-vote it a few times 
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "up")
                    post.Vote(1);
                if(input == "down")
                    post.Vote(-1);
                if (input == "end")
                    break;
            }
            
            //post.Vote(4); results in invalid data exception
            
            //and then display the the current vote value. 
            post.showVote();
            
            //post. does not bring up the _voteValue field
            //post.CreatedDate = DateTime.Now;
            
        }
    }
}