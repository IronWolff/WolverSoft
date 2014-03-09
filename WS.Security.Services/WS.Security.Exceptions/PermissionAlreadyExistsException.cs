using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class PermissionAlreadyExistsException : Exception
    {
        public PermissionAlreadyExistsException()
        {
        }

        public PermissionAlreadyExistsException(string message)
            : base(message)
        {
        }

        public PermissionAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected PermissionAlreadyExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
