using System;
using System.IO;
using System.Text;

namespace KPO_laba11_1
{
    /* Конкретный класс-строитель для создание текстовой статьи
    Получает данные от Director через интерфейс*/
    public class BuilderTXT:IBuilder
    {
        private ArticleTXT articleTXT;
        public void reset()
        {
            articleTXT = new ArticleTXT();
        }
        public void setTitle(string title)
        {
            articleTXT.Title = title;
        }
        public void setText(string text)
        {
            string path = Directory.GetCurrentDirectory();

            /*pathFile = pathFile.Replace("bin", "");
			pathFile = pathFile.Replace("Debug", "");
			pathFile = pathFile.Replace("netcoreapp3.0", "");*/
			path += @"\ArticleTXT.txt";
			articleTXT.Text = new FileInfo(path);
            
			using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fileStream.WriteAsync(array, 0, array.Length);
            };
            setHashCode(text);
        }
        public void setHashCode(string text)
        {
            int code = 0;
            articleTXT.HashCode = code;
        }
        public IArticle GetArticle()
        {
            return articleTXT;
        }
    }
}