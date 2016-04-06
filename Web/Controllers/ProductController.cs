using Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repositoryProduct)
        {
            this.repository = repositoryProduct;
        }

        // GET: Product
        public JsonResult ViewJason()
        {
            return Json(repository.Products,JsonRequestBehavior.AllowGet);
        }
    }
}