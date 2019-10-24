using System;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using Newtonsoft.Json;

namespace Data {
    public class RssReader {
        public static void syndicationTest() {
            XmlReader reader = XmlReader.Create("https://rss.itunes.apple.com/api/v1/us/apple-music/coming-soon/all/10/explicit.rss");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            feed.LastUpdatedTime = DateTimeOffset.Now;
            foreach (var item in feed.Items) {
                Console.WriteLine(item.Title.Text);
                //Console.WriteLine(item.Summary.Text);   
            }
            Console.WriteLine(feed.LastUpdatedTime);
            reader.Close();
            Console.ReadKey();
        }
        public void xmlToJson() {
            var feedUrl = ("https://rss.itunes.apple.com/api/v1/us/apple-music/coming-soon/all/10/explicit.rss");
            XmlDocument rss = new XmlDocument();
            rss.Load(feedUrl);
            string json = JsonConvert.SerializeXmlNode(rss);
            Console.WriteLine(json);
            string path = "swag.json";
            File.WriteAllText(path, json);
            Console.ReadKey();
        }

        public void saveXml() {

        }

        public void readXml() {

        }

        public void createPodcastFolder() {
            if (!Directory.Exists("Podcasts")) {
                Directory.CreateDirectory("Podcasts");
            }
        }
        public void createPodcastDb() {
            if (!File.Exists("Podcasts/PodcastDb.json")) {
                using (FileStream fs = File.Create("Podcasts/PodcastDb.json")) {
                }
            }
        }
    }
}
