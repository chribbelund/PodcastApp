using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace Data {
    public class WriteJson {
        public void GetRss() {

            var feedUrl = ("https://rss.itunes.apple.com/api/v1/us/apple-music/coming-soon/all/10/explicit.rss");
            XmlDocument rss = new XmlDocument();
            rss.Load(feedUrl);
            string json = JsonConvert.SerializeXmlNode(rss);
            Console.WriteLine(json);
            File.WriteAllText(feedUrl +".json" , json);
            Console.ReadKey();
        }
    }
}


/*
XmlReader xr = XmlReader.Create("http://www.hotukdeals.com/rss/hot");
SyndicationFeed feed = SyndicationFeed.Load(xr);
string json;
foreach (var item in feed.Items) {

}

return deals;
*/
