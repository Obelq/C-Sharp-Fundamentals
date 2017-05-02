namespace OnlineRadioDatabase
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string ErrorText = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException()
            :base(ErrorText)
        {

        }
        public InvalidSongMinutesException(string message) : base(message)
        {
        }
    }
}