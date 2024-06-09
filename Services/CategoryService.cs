using Microsoft.EntityFrameworkCore;
using TP2CORE.Model;
using TP2CORE.Repositories;

namespace TP2CORE.Services
{
    public class CategoryService : ICategoryInterface
    {
        private  ApplicationDbContext _db;
        public CategoryService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<Categorie> CreateCategory(Categorie
        category)
        {
            _db.categorie.Add(category);

            await _db.SaveChangesAsync();
            return category;
        }
        public async Task<Categorie> DeleteCategory(int id)
        {
            var catIndB = await _db.categorie.FindAsync(id);
            _db.categorie.Remove(catIndB);
            await _db.SaveChangesAsync();
            return catIndB;
        }
        public async Task<Categorie> EditCategory(int id,
        Categorie category)
        {
            var catInDb = await _db.categorie.FindAsync(id);
            catInDb.Name = category.Name;
            await _db.SaveChangesAsync();
            return catInDb;
        }
        public async Task<IEnumerable<Categorie>>
        GetAllCategories()
        {
            var cat = await _db.categorie.ToListAsync();
            return cat;
        }
    }
}

