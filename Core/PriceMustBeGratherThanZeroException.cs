
namespace Core
{
    [Serializable]
    internal class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException()
        {
        }

        public PriceMustBeGratherThanZeroException(string? message) : base(message)
        {
        }

        public PriceMustBeGratherThanZeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}