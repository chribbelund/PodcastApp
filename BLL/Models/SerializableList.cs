using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SerializeableList<T> : List<T>, Serializable where T : Serializable, new()
    {
        public string Serialize()
        {
            var lines = new List<string>();
            foreach (var item in this)
            {
                lines.Add(item.Serialize());
            }
            return string.Join("\n", lines.ToArray());
        }

        public void Deserialize(string serializedString)
        {
            var lines = serializedString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                try
                {
                    Add(SerializeableMaker.FromString<T>(line));
                }
                catch (Exception ex)
                {
                    throw ex as DeserializationException;
                }
            }
        }
    }
}
