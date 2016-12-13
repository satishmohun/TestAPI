using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TestApi.Models;
using TestApi.Models.Repository;
using Unity.Mvc5;

namespace TestApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<IStudent, StudentRepo>(new HierarchicalLifetimeManager());

        }
    }
}