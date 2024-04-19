using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagementWIthIdentity.Contants;

namespace UserManagementWIthIdentity.Controllers
{
    public class ProductsController : Controller
    {
        [Authorize(Permissions.Products.View)]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Permissions.Products.Edit)]
        public IActionResult Edit()
        {
            return View();
        }
        [Authorize(Permissions.Products.Create)]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Permissions.Products.Delete)]
        public IActionResult Delete()
        {
            return View();
        }
      
    }
}
