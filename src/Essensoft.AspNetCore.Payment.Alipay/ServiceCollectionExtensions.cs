using Essensoft.AspNetCore.Payment.Alipay;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(this IServiceCollection services)
        {
            services.AddHttpClient(nameof(AlipayClient));

            services.AddSingleton<AlipayPublicKeyManager>();
            services.AddSingleton<IAlipayClient, AlipayClient>();
            services.AddSingleton<IAlipayNotifyClient, AlipayNotifyClient>();
        }
    }
}