using _06Repository.Models;

namespace _06Repository.DAL
{
    public interface IArticleRepository : IDisposable
    {
        IEnumerable<Article> GetAll();
        Article Get(int ArticleId);
        void Create(Article article);
        void Update(Article article);
        void Delete(int ArticleId);
        void Save();
    }
}
