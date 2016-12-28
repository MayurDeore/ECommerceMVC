using ECommerce.Services.OrderServices;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;
using ECommerce.Services;
namespace ECommerce.Web.Models
{

    public static class IocExtensions
        {
            public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
            {
                container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
            }

            public static void BindInSingletonScope<T1, T2>(this IUnityContainer container) where T2 : T1
            {
                container.RegisterType<T1, T2>(new ContainerControlledLifetimeManager());
            }
        }
        public class UnityMvc
        {
            public static void Start()
            {
                var container = BuildUnityContainer();
                DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            }

            private static IUnityContainer BuildUnityContainer()
            {
                var container = new UnityContainer();

                // register all your components with the container here
                // it is NOT necessary to register your controllers

                // Database context, one per request, ensure it is disposed
                container.BindInRequestScope<IDBContext, DBContext>();

                //Bind the various domain model services and repositories that e.g. our controllers require         
                container.BindInRequestScope<IOrderService, OrderService>();
                

                //container.BindInRequestScope<ISessionHelper, SessionHelper>();

                return container;
            }
        }
    
}