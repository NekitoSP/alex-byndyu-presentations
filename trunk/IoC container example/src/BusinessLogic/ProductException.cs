using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class ProductException : Exception
    {
        public ProductException()
        {
        }

        public ProductException(string message) : base(message)
        {
        }

        public ProductException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ProductException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}