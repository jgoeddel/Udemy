﻿using Udemy.DataAccess.Data;
using Udemy.DataAccess.Repository.IRepository;
using Udemy.Models;

namespace Udemy.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Category.FirstOrDefault(u => u.Id == category.Id);
            objFromDb.Name = category.Name;
            objFromDb.DisplayOrder = category.DisplayOrder;
        }
    }
}
