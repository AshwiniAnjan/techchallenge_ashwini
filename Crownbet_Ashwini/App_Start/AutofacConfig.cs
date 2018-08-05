using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Mvc;
using Crownbet_Ashwini.Helpers;
using Crownbet_Databse;
using Crownbet_Common;
using System.Reflection;
using System.Web.Http;

namespace Crownbet_Ashwini
{
        public class AutofacConfig
        {
            public static void ConfigureContainer()
            {
                var builder = new ContainerBuilder();

                builder.RegisterControllers(Assembly.GetExecutingAssembly()); //Register MVC Controllers
                builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

                builder.RegisterType<RaceHelper>().As<IRaceHelper>();
                builder.RegisterType<RaceDBConnector>().As<IRaceDBConnector>();
                builder.RegisterType<Logger>().As<ILogger>();
                IContainer container = builder.Build();

                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
                GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
            }
        }
    
}