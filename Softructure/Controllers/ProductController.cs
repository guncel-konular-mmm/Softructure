using Microsoft.AspNetCore.Mvc;
using Soft.BusinessLayer.Abstract;
using Soft.EntityLayer.Concrete;

namespace Softructure.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            // Constructor, ProductService bağımlılığını enjekte eder.
            this.productService = productService;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult GetAll()
        {
            var result = productService.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            productService.Add(product);
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public ActionResult ProductDelete(Product product)
        {
            productService.Delete(product);
            return RedirectToAction("GetAll");
        }
      
        [HttpPost]
        public ActionResult ProductUpdate(Product product)
        {
            productService.Update(product);
            return RedirectToAction("GetAll");
        }
    }
}
