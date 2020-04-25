using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsandCats.Models;

namespace ProductsandCats.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
     
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.CurProducts = dbContext.Products.ToList();
            return View("index");
        }

        [HttpPost("createprod")]
        public IActionResult CreateProd(Product newProd)
        {
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(newProd);
                dbContext.SaveChanges();
                return Redirect("/"); 
            }
            return View("index");
        }

        [HttpGet("/product/{ProductId}")]
        public IActionResult ViewProd(int ProductId)
        {
            Product oneProduct = dbContext.Products.Include( p => p.CatsForProd)
                                                   .ThenInclude( a => a.CategoryAssoc)
                                                   .FirstOrDefault(p => p.ProductId == ProductId);

            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine(oneProduct);

            ViewBag.AllCategories = dbContext.Categories.Include( c => c.ProdInCat)
                                                        .ThenInclude( a => a.ProductAssoc )
                                                        .ToList();
                                            
            return View("productinfo", oneProduct);
        }

        [HttpGet("/categories")]
        public IActionResult Categories()
        {
            ViewBag.Categories = dbContext.Categories.ToList();
            return View("categories");
        }

        [HttpPost("/createcat")]
        public IActionResult CreateCat(Category category)
        {
            if(ModelState.IsValid)
            {
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
                return Redirect("/categories");
            }
            return View("categories");
        }


        // relates a product to a category
        [HttpPost("/product/{prodId}/category")]
        public IActionResult  ProductAssociation(int prodId, int catId)
        {
            if(ModelState.IsValid)
            {

            Console.WriteLine("__________________________________________");
            Console.WriteLine(prodId);
            Console.WriteLine(catId);
            Asscotiation productCat = new Asscotiation();
            productCat.ProductId = prodId;
            productCat.CategoryId = catId;
            dbContext.Asscotiations.Add(productCat);
            dbContext.SaveChanges();
            return Redirect($"/product/{prodId}");
            }
            return Redirect($"/product/{prodId}");
        }

        [HttpPost("/category/{catId}/product")]
        public IActionResult CategoryAssociation( int prodId, int catId)
        {
            if(ModelState.IsValid)
            {

            Asscotiation catProd = new Asscotiation();
            catProd.ProductId = prodId;
            catProd.CategoryId = catId;
            dbContext.Asscotiations.Add(catProd);
            dbContext.SaveChanges();
            return Redirect($"/category/{catId}");
            }
            return Redirect($"/category/{catId}");
        }

        [HttpGet("/category/{catId}")]
         public IActionResult ViewCat(int catId)
        {
            Category oneCategory = dbContext.Categories.Include( c => c.ProdInCat)
                                                   .ThenInclude( a => a.ProductAssoc)
                                                   .FirstOrDefault(c => c.CategoryId == catId);

            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine(oneCategory);

            ViewBag.AllProducts = dbContext.Products.Include( p => p.CatsForProd)
                                                        .ThenInclude( a => a.CategoryAssoc )
                                                        .ToList();
                                            
            return View("categoryinfo", oneCategory);
        }
        

    }
 }