using System;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(
            this IServiceCollection services)
        {
            services.AddWeChatPay(null);
        }

        public static void AddWeChatPay(
            this IServiceCollection services,
            Action<WeChatPayOptions> setupAction)
        {
            services.AddHttpClient(nameof(WeChatPayClient));

            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, WeChatPayHandlerBuilderFilter>());

            services.AddSingleton<WeChatPayCertificateManager>();
            services.AddSingleton<IWeChatPayClient, WeChatPayClient>();
            services.AddSingleton<IWeChatPayNotifyClient, WeChatPayNotifyClient>();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}