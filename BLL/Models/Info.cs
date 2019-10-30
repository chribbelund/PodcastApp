using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Info : Serializable
    {
        public string Name { get; set; }
        public string Episode { get; set; }
        public string Frequency { get; set; }

        public void Deserialize(string serializedString)
        {
            var listOfString = serializedString.Split('|');
            if (listOfString.Length == 3)
            {
                Name = listOfString[0];
                Episode = listOfString[1];
                Frequency = listOfString[2];
            }
            else
            {
                throw new DeserializationException();
            }
        }

        public string Serialize()
        {
            return string.Join("|", new[] { Name, Episode, Frequency });
        }
    }
}
