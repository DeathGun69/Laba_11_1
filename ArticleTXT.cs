using System;
using System.IO;
using System.Text;

namespace KPO_laba11_1
{
    // Класс текстовой статьи
    public class ArticleTXT:IArticle
    {
        public string Title { get; set; }
        public FileInfo Text { get; set; }
        public int HashCode { get; set; }
        public void checkHashCode() { }
    } 
}