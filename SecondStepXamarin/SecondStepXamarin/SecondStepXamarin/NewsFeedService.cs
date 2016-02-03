using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SecondStepXamarin
{
    class NewsFeedService
    {
        static readonly string EndPoint = @"http://www.xlsoft.com/jp/rss/xlsoft_news.xml";

        public async Task<Rss> Update()
        {
            Rss latest;

            //public Rss Feed { get; set; }

            //public NewsFeedService()
            //{
            //    this.Feed = new Rss();
            //}

            using (var client = new HttpClient())
            {
                using (var reader = new StreamReader(await client.GetStreamAsync(EndPoint)))
                {
                    var deserializer = new XmlSerializer(typeof(Rss));
                    latest = deserializer.Deserialize(reader) as Rss;
                    return latest;
                }
            }
        }
    }
}
