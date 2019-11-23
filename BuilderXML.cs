using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace KPO_laba11_1
{
    public class BuilderXML:IBuilder
    {
        public ArticleXML articleXML;
        public void reset()
        {
            articleXML = new ArticleXML();
        }
        public void setTitle(string title)
        {
            articleXML.Title = title;
        }
        public void setText(string text)
        {
            string pathFile = Directory.GetCurrentDirectory();
            //pathFile = pathFile.Replace("bin", "");
            pathFile += @"\ArticleXML.txt";

            XDocument xDocument = new XDocument();
            XElement Article = new XElement("Article");
            XAttribute title = new XAttribute("name", articleXML.Title);
            XElement textArticle = new XElement("text", text);
            setHashCode(text);
            XElement HashCode = new XElement("name", articleXML.HashCode);
            Article.Add(title);
            Article.Add(textArticle);
            Article.Add(HashCode);
            xDocument.Add(Article);
            xDocument.Save("ArticleXML.xml");
            articleXML.Text = new FileInfo(pathFile);
        }

        public void setHashCode(string text)
        {
            int code = 0;
            articleXML.HashCode = code;
        }

        public IArticle GetArticle()
        {
            return articleXML;
        }
    }
}