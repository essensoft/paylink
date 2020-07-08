using Essensoft.AspNetCore.Payment.WeChatPay;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(this IServiceCollection services)
        {
            services.AddHttpClient(nameof(WeChatPayClient));

            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, WeChatPayHttpMessageHandlerBuilderFilter>());

            services.AddSingleton<WeChatPayClientCertificateManager>();
            services.AddSingleton<WeChatPayPlatformCertificateManager>();
            services.AddSingleton<IWeChatPayClient, WeChatPayClient>();
            services.AddSingleton<IWeChatPayNotifyClient, WeChatPayNotifyClient>();
        }
    }
}
