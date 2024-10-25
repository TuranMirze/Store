
namespace ConsoleApp8
{
    [Serializable]
    internal class PriceMustBeGreaterThanZeroException : Exception
    {
        public PriceMustBeGreaterThanZeroException()
        {
        }

        public PriceMustBeGreaterThanZeroException(string? message) : base(message)
        {
        }

        public PriceMustBeGreaterThanZeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}