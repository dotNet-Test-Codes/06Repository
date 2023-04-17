using _06Repository.Data;
using _06Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace _06Repository.DAL
{
    public class ArticleRepository : IArticleRepository, IDisposable
    {
        private ArticleDBContext _context;
        public ArticleRepository(ArticleDBContext context)
        {
            _context = context;
        }
        public void Create(Article article)
        {
            _context.Articles.Add(article);
        }

        public void Delete(int ArticleId)
        {
            Article article = _context.Articles.Find(ArticleId);
            _context.Articles.Remove(article);
        }

        public Article Get(int ArticleId)
        {
            return _context.Articles.Find(ArticleId);
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Article article)
        {
            _context.Entry(article).State = EntityState.Modified;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
