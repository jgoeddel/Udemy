using Udemy.Models;

namespace Udemy.DataAccess.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
        void Save();
    }
}
