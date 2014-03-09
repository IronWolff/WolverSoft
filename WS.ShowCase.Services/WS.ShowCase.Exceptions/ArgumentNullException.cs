using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class ArgumentNullException : Exception
    {
        public ArgumentNullException() 
        {
        }

        public ArgumentNullException(string message) : base(message) 
        {
        }
        
        public ArgumentNullException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected ArgumentNullException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
