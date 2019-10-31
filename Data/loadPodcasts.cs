using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testing {
    class loadPodcasts {


        public string[] getPodcasts() {
            string[] fileArray = Directory.GetFiles("Podcasts/");
            foreach (var item in fileArray) {
                Console.WriteLine(item);
            }
            return fileArray;
        }
        public void deletePodcast(string filename) {
            File.Delete(filename);
        }

    }
}
