using PC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace testing {

    [Serializable]
    public class saveRss : IDisposable {
        private string _feedTitle;
        private Collection<Rss.Items> _rssItems = new Collection<Rss.Items>();
        private bool _IsDisposed;
        private string _channelTitle;

        public Collection<Rss.Items> RssItems {
            get { return _rssItems; }
        }
        public Collection<Rss.Items> GetFeed(string url) {
            //check to see if the FeedURL is empty
            if (String.IsNullOrEmpty(url)) {
                throw new ArgumentException("You must provide a feed URL");
            }
            using (XmlReader reader = XmlReader.Create(url)) {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "title", ref _feedTitle);
                ParseRssItems(xmlDoc);
                saveJson(_rssItems);
                return _rssItems;
            }
        }

        //Laddar in en xml fil och lägger in de releveanta elementen i en collection
        private void ParseRssItems(XmlDocument rss) {
            _rssItems.Clear();
            XmlNodeList nodes = rss.SelectNodes("rss/channel/item");
            XmlNode channelTitle = rss.SelectSingleNode("rss/channel/title");
            _channelTitle = channelTitle.InnerXml;
            foreach (XmlNode node in nodes) {
                Rss.Items item = new Rss.Items();
                ParseDocElements(node, "title", ref item.Title);
                ParseDocElements(node, "description", ref item.Description);
                _rssItems.Add(item);
            }
        }

        //sparar collectionen till en json
        private void saveJson(Collection<Rss.Items> items) {

            var serializer = CreateSerializer();
            using (var sw = new StreamWriter("Podcasts/"+_channelTitle + ".json")) {
                using (var jw = new JsonTextWriter(sw)) {
                    serializer.Serialize(jw, items);
                }
            }
        }



        #region Private methods
        private void ParseDocElements(XmlNode parent, string xPath, ref string property) {
            XmlNode node = parent.SelectSingleNode(xPath);
            if (node != null)
                property = node.InnerText;
            else
                property = "fel";
        }
        private void Dispose(bool disposing) {
            if (disposing && !_IsDisposed) {
                _rssItems.Clear();
                _feedTitle = null;
            }

            _IsDisposed = true;
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private JsonSerializer CreateSerializer() {
            return new JsonSerializer {
                TypeNameHandling = TypeNameHandling.All
            };
        }
        #endregion
    }
}
