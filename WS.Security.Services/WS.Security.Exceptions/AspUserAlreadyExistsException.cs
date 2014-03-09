using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class AspUserAlreadyExistsException : Exception
    {
        public AspUserAlreadyExistsException()
        {
        }

        public AspUserAlreadyExistsException(string message)
            : base(message)
        {
        }

        public AspUserAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected AspUserAlreadyExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
