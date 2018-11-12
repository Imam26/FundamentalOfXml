using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Item
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }

        public void Show()
        {
            Console.WriteLine("<item>");
            Console.WriteLine(" <title>{0}</title>", Title);
            Console.WriteLine("   <link>{0}</link>", Link);
            Console.WriteLine("   <description>{0}</description>", Description);
            Console.WriteLine(" <puDate>{0}</pubDate>", PubDate);
            Console.WriteLine("</item>");
        }
    }
}
