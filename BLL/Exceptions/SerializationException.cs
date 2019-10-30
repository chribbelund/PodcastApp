using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SerializationException : Exception
    {
        public SerializationException() : base("Serialization failed!") { }
        public SerializationException(string message) : base(message) { }
    }

    public class DeserializationException : SerializationException { }
}
