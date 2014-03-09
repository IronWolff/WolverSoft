using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class BrandDoesNotExistsException : Exception
    {
        public BrandDoesNotExistsException() 
        {
        }

        public BrandDoesNotExistsException(string message) : base(message) 
        {
        }
        
        public BrandDoesNotExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected BrandDoesNotExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
