using System.Web.Http;
using WebActivatorEx;
using Api;
using Swashbuckle.Application;
using System.IO;
using System.Reflection;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Exam GALACTIC");
                    c.IncludeXmlComments(GetXMLPath());
                })
                .EnableSwaggerUi(c =>
                {
                    c.DocumentTitle("Pruebas API por el imperio");
                    c.DocExpansion(DocExpansion.Full);
                });
        }

        private static string GetXMLPath()
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", xmlFile);

            return xmlPath;
        }
    }
}
