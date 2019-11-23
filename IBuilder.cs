namespace KPO_laba11_1
{
    // Интерфейс строителья
    public interface IBuilder
    {
        void reset(){ }
        void setTitle(string title){ }
        void setText(string text){ }
        IArticle GetArticle();
    }
}