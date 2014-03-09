using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class ApplicationAlreadyExistsException : Exception
    {
        public ApplicationAlreadyExistsException()
        {
        }

        public ApplicationAlreadyExistsException(string message)
            : base(message)
        {
        }

        public ApplicationAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ApplicationAlreadyExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
