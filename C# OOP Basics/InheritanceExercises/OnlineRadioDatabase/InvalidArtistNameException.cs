namespace OnlineRadioDatabase
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string ErrorText = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            :base(ErrorText)
        {

        }
        public InvalidArtistNameException(string message) : base(message)
        {
        }
    }
}