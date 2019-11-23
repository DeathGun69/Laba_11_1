using System;
using System.IO;
using System.Text;

namespace KPO_laba11_1
{
    // Класс xml-статьи
    public class ArticleXML:IArticle
    {
        public string Title { get; set; }
        public FileInfo Text { get; set; }
        public int HashCode { get; set; }
        public void checkHashCode() { }
    }
}