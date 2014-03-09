using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class PermissionDoesNotExistException : Exception
    {
        public PermissionDoesNotExistException()
        {
        }

        public PermissionDoesNotExistException(string message)
            : base(message)
        {
        }

        public PermissionDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected PermissionDoesNotExistException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
