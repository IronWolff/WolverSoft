using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
        {
        }

        public UserAlreadyExistsException(string message)
            : base(message)
        {
        }

        public UserAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected UserAlreadyExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
