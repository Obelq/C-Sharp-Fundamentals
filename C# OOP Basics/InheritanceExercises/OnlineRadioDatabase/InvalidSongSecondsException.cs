namespace OnlineRadioDatabase
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string ErrorText = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException()
            :base(ErrorText)
        {

        }
        public InvalidSongSecondsException(string message) : base(message)
        {
        }
    }
}