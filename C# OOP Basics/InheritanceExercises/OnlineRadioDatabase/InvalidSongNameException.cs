namespace OnlineRadioDatabase
{
    public class InvalidSongNameException : InvalidSongException
    {
        private const string ErrorText = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException()
            :base(ErrorText)
        {

        }
        public InvalidSongNameException(string message) : base(message)
        {
        }
    }
}