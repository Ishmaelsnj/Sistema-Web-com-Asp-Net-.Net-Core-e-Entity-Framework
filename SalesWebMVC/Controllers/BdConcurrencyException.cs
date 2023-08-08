using System;
using System.Runtime.Serialization;

namespace SalesWebMVC.Controllers
{
    [Serializable]
    internal class BdConcurrencyException : Exception
    {
        public BdConcurrencyException()
        {
        }

        public BdConcurrencyException(string message) : base(message)
        {
        }

        public BdConcurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BdConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}