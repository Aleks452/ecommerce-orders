namespace Orders.Exceptions
{
    public class NoDataFoundException : Exception
    {
        public int ErrorCode { get; } = 422;

        public NoDataFoundException() : base("Information with criterial given not found.")
        {
        }

        public NoDataFoundException(string message) : base(message)
        {
        }

        public NoDataFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}