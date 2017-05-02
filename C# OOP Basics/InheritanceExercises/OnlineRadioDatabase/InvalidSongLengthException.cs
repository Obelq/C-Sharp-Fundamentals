namespace OnlineRadioDatabase
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string ErrorText = "Invalid song length.";

        public InvalidSongLengthException()
            :base(ErrorText)
        {

        }
        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}