using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.WebUI.Models;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 6;
        IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                CurrentCategory = category,
                Products = repository.Products
                            .Where(p => category == null || p.Category == category)
                            .OrderBy(p => p.ProductID)
                            .Skip((page - 1) * PageSize)
                            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Products.Count() : 
                                 repository.Products.Where(e => e.Category == category).Count()
                }, 
            };
            return View(model);
        } 


        public ViewResult Search(string search_Value, int page = 1)
        {
            ViewBag.SearchValue = search_Value;
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                         .Where(p => search_Value == null || p.Name.ToUpper().Contains(search_Value.ToUpper()))
                         .OrderBy(p => p.ProductID)
                         .Skip((page - 1) * PageSize)
                         .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = String.IsNullOrEmpty(search_Value) ? repository.Products.Count() :
                              repository.Products.Where(e => e.Name == search_Value).Count()
                },
            };
            return View("List", model);
        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products
                           .FirstOrDefault
                           (p => p.ProductID == productId);
                if (prod != null)
                {
                    return File(prod.ImageData, prod.ImageMimeType);
                }
                else
                {
                    return null;
                }
        }

    }
}