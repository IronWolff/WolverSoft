using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class ApplicationModuleDoesNotExistException : Exception
    {
        public ApplicationModuleDoesNotExistException()
        {
        }

        public ApplicationModuleDoesNotExistException(string message)
            : base(message)
        {
        }

        public ApplicationModuleDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ApplicationModuleDoesNotExistException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
