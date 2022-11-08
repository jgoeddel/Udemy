using Udemy.Models;

namespace Udemy.DataAccess.Repository.IRepository
{
    public interface IFoodTypeRepository : IRepository<FoodType>
    {
        void Update(FoodType foodType);
        void Save();
    }
}
