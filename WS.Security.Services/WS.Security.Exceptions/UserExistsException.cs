using System;
using System.Runtime.Serialization;

namespace WS.Security.Exceptions
{
    public class UserExistsException : Exception
    {
        public UserExistsException() 
        {

        }
        public UserExistsException(string message) : base(message) 
        {
        
        }
        public UserExistsException(string message, Exception innerException) : base(message, innerException) 
        {
        
        }
        protected UserExistsException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) 
        {

        }
    }
}
