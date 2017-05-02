using System;

namespace OnlineRadioDatabase
{
    public class InvalidSongException:Exception
    {
        private const string ErrorText = "Invalid song.";

        public InvalidSongException()
            :base(ErrorText)
        {
            
        }
        public InvalidSongException(string message) 
            : base(message)
        {
        }
    }
}