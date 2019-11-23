using System;
using System.IO;
using System.Text;

namespace KPO_laba11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Director.layoutArticle(new BuilderTXT(), "Neurons", "text");
            ArticleTXT articleTXT = (ArticleTXT) Director.GetArticle();
            Console.WriteLine(articleTXT.Title);

            Director.convertArticle(new BuilderXML(), articleTXT);
            ArticleXML articleXML = (ArticleXML) Director.GetArticle();
            Console.WriteLine(articleXML.Title);
        }
    }
}
