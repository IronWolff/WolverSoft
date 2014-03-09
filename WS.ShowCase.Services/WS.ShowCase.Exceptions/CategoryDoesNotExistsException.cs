using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class CategoryDoesNotExistsException : Exception
    {
        public CategoryDoesNotExistsException() 
        {
        }

        public CategoryDoesNotExistsException(string message) : base(message) 
        {
        }
        
        public CategoryDoesNotExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected CategoryDoesNotExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
