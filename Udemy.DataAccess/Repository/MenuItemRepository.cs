using Udemy.DataAccess.Data;
using Udemy.DataAccess.Repository.IRepository;
using Udemy.Models;

namespace Udemy.DataAccess.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDbContext _db;
        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(MenuItem obj)
        {
            var objFromDb = _db.MenuItem.FirstOrDefault(u => u.Id == obj.Id);
            objFromDb.Name = obj.Name;
            objFromDb.Description = obj.Description;            
            objFromDb.Price = obj.Price;
            objFromDb.FoodTypeId = obj.FoodTypeId;
            objFromDb.CategoryId = obj.CategoryId;
            if(objFromDb.Image != null)
            {
                objFromDb.Image = obj.Image;
            }
        }
    }
}
