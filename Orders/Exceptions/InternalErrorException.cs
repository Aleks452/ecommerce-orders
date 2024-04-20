namespace Orders.Exceptions
{
    public class InternalErrorException : Exception
    {
        public int ErrorCode { get; } = 500;

        public InternalErrorException() : base("Unexpected error has occurred.")
        {
        }

        public InternalErrorException(string message) : base(message)
        {
        }

        public InternalErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
