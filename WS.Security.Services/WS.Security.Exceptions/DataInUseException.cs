using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class DataInUseException : Exception
    {
        public DataInUseException()
        {
        }

        public DataInUseException(string message)
            : base(message)
        {
        }

        public DataInUseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DataInUseException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
