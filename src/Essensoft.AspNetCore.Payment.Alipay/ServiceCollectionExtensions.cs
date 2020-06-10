using Microsoft.Extensions.DependencyInjection;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(this IServiceCollection services)
        {
            services.AddHttpClient(nameof(AlipayClient));

            services.AddSingleton<AlipayPublicKeyManager>();
            services.AddSingleton<IAlipayClient, AlipayClient>();

#if NETCOREAPP3_1
            services.AddSingleton<IAlipayNotifyClient, AlipayNotifyClient>();
#endif
        }
    }
}