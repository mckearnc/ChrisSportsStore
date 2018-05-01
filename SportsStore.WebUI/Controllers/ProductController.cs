using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstractt;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    //In addition to removing the Index action method, p.164
    //    I added a constructor that declares a dependency 
    //    on the IProductRepository interface, which will 
    //    lead Ninject to inject the dependency for the product
    //    repository when it instantiates the controller class. 
    //    I also imported the SportsStore.Domain namespaces so that 
    //    I can refer to the repository and model classes without 
    //    having to qualify their names.

    public class ProductController : Controller{
        private IProductsRepository repository;

        public ProductController(IProductsRepository productsRepository){
            this.repository = productsRepository;
        }

        public ViewResult List(){
            return View(repository.Products);
            //p.164 Added method called List which will render a 
            //view showing the complete list of products.
            //Calling the View method like this(without 
            //specifying a view name) tells the framework 
            //to render the default view for the action 
            //method.Passing a List of Product objects 
            //to the View method, provides the framework 
            //with the data with which to populate the 
            //Model object in a strongly typed view.
        }
    }
}