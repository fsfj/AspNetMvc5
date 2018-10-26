using System.Web.Mvc;
using AspNetMvc5.Models;
using AspNetMvc5.Repositories;
using Unity;
using Unity.Mvc5;

namespace AspNetMvc5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ICategoriesRepository, CategoriesRepository>();
            container.RegisterType<AspNetMvc5Context>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}