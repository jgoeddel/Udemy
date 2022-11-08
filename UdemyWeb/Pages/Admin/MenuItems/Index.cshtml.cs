using Microsoft.AspNetCore.Mvc.RazorPages;
using Udemy.DataAccess.Repository.IRepository;
using Udemy.Models;

namespace UdemyWeb.Pages.Admin.MenuItems
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<MenuItem> MenuItem { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            MenuItem = _unitOfWork.MenuItem.GetAll();
        }
    }
}
