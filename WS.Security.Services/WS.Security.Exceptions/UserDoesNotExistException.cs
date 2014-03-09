using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class UserDoesNotExistException : Exception
    {
        public UserDoesNotExistException()
        {
        }

        public UserDoesNotExistException(string message)
            : base(message)
        {
        }

        public UserDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected UserDoesNotExistException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
