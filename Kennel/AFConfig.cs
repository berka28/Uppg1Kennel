using Autofac;
using System.Linq;
using System.Reflection;

namespace Kennel
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            
            builder.RegisterType<Application>().As<IApplication>();

            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Services"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

           
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Rental"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}