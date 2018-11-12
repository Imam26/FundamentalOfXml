using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("https://habrahabr.ru/rss/interesting/");

            XmlNodeList nodes = xmlDocument.GetElementsByTagName("item");

            foreach(XmlNode node in nodes)
            {
                Item tempItem = new Item();

                foreach(XmlNode childNode in node)
                {
                    switch (childNode.Name)
                    {
                        case "title":
                            tempItem.Title = childNode.InnerText;
                            break;
                        case "link":
                            tempItem.Link = childNode.InnerText;
                            break;
                        case "description":
                            tempItem.Description = childNode.InnerText;
                            break;
                        case "pubDate":
                            tempItem.PubDate = childNode.InnerText;
                            break;
                        default:break;
                    }
                }

                items.Add(tempItem);
            }

            foreach(Item item in items)
            {
                item.Show();
            }
        }
    }
}
