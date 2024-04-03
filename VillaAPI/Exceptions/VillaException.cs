namespace VillaAPI.Exceptions
{
    public class VillaException : Exception
    {
        public VillaException()
        {

        }

        public VillaException(string message) : base(message)
        {

        }

        public VillaException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
