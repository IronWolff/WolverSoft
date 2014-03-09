using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Exceptions
{
    public class UserDoesNotExistsException : Exception
    {
        public UserDoesNotExistsException() 
        {
        }

        public UserDoesNotExistsException(string message) : base(message) 
        {
        }
        
        public UserDoesNotExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        protected UserDoesNotExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        { 
        }
    }
}
