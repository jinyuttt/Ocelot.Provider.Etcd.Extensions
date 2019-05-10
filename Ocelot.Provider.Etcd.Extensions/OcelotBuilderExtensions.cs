namespace Ocelot.Provider.Etcd.Extensions
{
    using DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;

    public static class OcelotBuilderExtensions
    {
        /// <summary>
        /// add last
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IOcelotBuilder AddEtcdCluster(this IOcelotBuilder builder)
        {
            builder.Services.Replace(ServiceDescriptor.Singleton<IEtcdClientFactory, EtcdClientClusterFactory>());
            return builder;
        }

       
    }
}