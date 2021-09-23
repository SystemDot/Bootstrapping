namespace SystemDot.Bootstrapping
{
    using System.Net.Mime;
    using SystemDot.Ioc;

    public static class IocContainerExtensions
    {
        public static void RegisterComponents(this IIocContainer container)
        {
            container.RegisterInstance<IApplication, Application>();
        }
    }
}