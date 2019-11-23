using System;
using System.IO;
using System.Text;

namespace KPO_laba11_1
{
    // Класс Director управляет работой строителей
    public static class Director 
    {
        private static IArticle article;
        // Класс отвечает за создание статьи, передаем строителю заголовок и текст статьи через интерфейс IBuilder
        public static void layoutArticle(IBuilder builder, string Title, string Text)
        {
            builder.reset();
            builder.setTitle(Title);
            builder.setText(Text);
            article = builder.GetArticle();
        }

        // Класс отвечает за конвертациию статьи
        public static void convertArticle(IBuilder builder, ArticleTXT article_txt)
        {
            builder.reset();
            builder.setTitle(article_txt.Title);

            using (FileStream fileStream = File.OpenRead(article_txt.Text.FullName))
            {
                byte[] array = new byte[fileStream.Length];
                fileStream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                builder.setText(textFromFile);
            }
            article = builder.GetArticle();
        }
        
        public static IArticle GetArticle()
        {
            return article;
        }
    }
}