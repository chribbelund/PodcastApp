using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;


namespace BLL
{
    public class Category //: Serializable
    {
        public string Categorys { get; set; }
        List<string> titlar = new List<string>();

        public void GetCategorys()
        {
            foreach (var test in titlar)
            {
                var listItem = new ListViewItem(
                    new[] { test }
                );
            }
        }

        public void SetCategorys(string Category)
        {
            Category = Categorys;
            for (int i = Categorys.Contains(Category); i >= 0; i--)
            {

            }
        }
        /*public void Deserialize(string serializedString)
        {
            var listOfString = serializedString.Split('|');
            if (listOfString.Length == 1)
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
        }*/
    }
}
