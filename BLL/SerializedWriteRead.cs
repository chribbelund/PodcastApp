using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SerializedReaderWriter
    {
        public static T Read<T>(string filename) where T : Serializable, new()
        {
            var filecontent = "";

            using (var fs = new FileStream(filename, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    filecontent = sr.ReadToEnd();
                }
            }

            if (!string.IsNullOrEmpty(filecontent))
            {
                try
                {
                    return SerializeableMaker.FromString<T>(filecontent);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            throw new SerializationException("Couldn't read file!");
        }

        public static void Write<T>(string filename, T data) where T : Serializable
        {
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(data.Serialize());
                }
            }
        }
    }
}
