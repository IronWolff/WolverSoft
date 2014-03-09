using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class ProductDoesNotExistsException : Exception
    {
        public ProductDoesNotExistsException() 
        {
        }

        public ProductDoesNotExistsException(string message) : base(message) 
        {
        }
        
        public ProductDoesNotExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected ProductDoesNotExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
