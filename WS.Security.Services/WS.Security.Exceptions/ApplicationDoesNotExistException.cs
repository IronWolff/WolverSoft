using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class ApplicationDoesNotExistException : Exception
    {
        public ApplicationDoesNotExistException()
        {
        }

        public ApplicationDoesNotExistException(string message)
            : base(message)
        {
        }

        public ApplicationDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ApplicationDoesNotExistException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
