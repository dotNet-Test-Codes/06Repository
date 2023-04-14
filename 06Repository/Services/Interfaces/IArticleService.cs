using _06Repository.Models;

namespace _06Repository.Services.Interfaces
{
    public interface IArticleService
    {
        List<Article> GetAll();
        Article Get(int id);
        Article Create(Article article);
        Article Update(Article article);
        Article Delete(int id);
        void Save();
    }
}
