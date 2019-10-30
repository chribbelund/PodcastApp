using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Category : Serializable
    {
        public string Categorys { get; set; }

        public void Deserialize(string serializedString)
        {
            var listOfString = serializedString.Split('|');
            if (listOfString.Length == 2)
            {
                Categorys = listOfString[0];
            }
            else
            {
                throw new DeserializationException();
            }
        }

        public string Serialize()
        {
            return string.Join("|", new[] { Categorys });
        }
    }
}
