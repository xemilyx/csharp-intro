using System;
using System.IO;

namespace PostExercise
{
    public class Post
    {
        //It should have properties for title, description and the date/time it was created. 
        public string Title { get; set; }

        public string Description { get; set; }
        
        public DateTime CreatedDate { get; set; }

        //You should not give the ability to set the Vote property from the outside.
        
        private int _voteValue;

        public Post()
        {
            this.CreatedDate = DateTime.Now;
        }

        //We should be able to up-vote or down-vote a post. 

        public void Vote(int direction)
        {
            if (direction == -1 || direction == 1)
                _voteValue += direction;
            else throw new InvalidDataException("You only get one vote!");
        }
        
        //We should also be able to see the current vote value. 

        public void showVote()
        {
            Console.WriteLine("Current vote value: " + _voteValue);
        }
        
    }
}