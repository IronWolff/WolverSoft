using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class ProviderDoesNotExistsException : Exception
    {
        public ProviderDoesNotExistsException() 
        {
        }

        public ProviderDoesNotExistsException(string message) : base(message) 
        {
        }
        
        public ProviderDoesNotExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected ProviderDoesNotExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
