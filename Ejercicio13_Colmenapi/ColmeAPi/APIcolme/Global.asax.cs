using ColmeApi.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

using Unity.AspNet.WebApi;

namespace APIcolme
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            

            var container = new UnityContainer();

            // Registra la implementación del repositorio de abejas
            container.RegisterType<IAbejaRepository, AbejaRepository>();

            // Registra el controlador
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            
        }
    }
}

