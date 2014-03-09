using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class ApplicationModuleAlreadyExistsException : Exception
    {
        public ApplicationModuleAlreadyExistsException()
        {
        }

        public ApplicationModuleAlreadyExistsException(string message)
            : base(message)
        {
        }

        public ApplicationModuleAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ApplicationModuleAlreadyExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
