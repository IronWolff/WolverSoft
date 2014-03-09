using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class RoleExistsException : Exception
    {
        public RoleExistsException()
        {
        }

        public RoleExistsException(string message)
            : base(message)
        {
        }

        public RoleExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected RoleExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
