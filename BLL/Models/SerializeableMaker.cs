using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SerializeableMaker
    {
        public static T FromString<T>(string input) where T : Serializable, new()
        {
            try
            {
                var obj = new T();
                obj.Deserialize(input);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex as DeserializationException;
            }
        }
    }
}
