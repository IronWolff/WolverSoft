using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class RoleDoesNotExistException : Exception
    {
        public RoleDoesNotExistException()
        {
        }

        public RoleDoesNotExistException(string message)
            : base(message)
        {
        }

        public RoleDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected RoleDoesNotExistException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
