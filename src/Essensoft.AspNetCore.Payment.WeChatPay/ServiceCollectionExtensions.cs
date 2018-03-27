using Essensoft.AspNetCore.Payment.WeChatPay;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(
            this IServiceCollection services)
        {
            services.AddWeChatPay(setupAction: null);
        }

        public static void AddWeChatPay(
            this IServiceCollection services,
            Action<WeChatPayOptions> setupAction)
        {
            services.AddSingleton<WeChatPayClient>();
            services.AddSingleton<WeChatPayCertificateClient>();
            services.AddSingleton<WeChatPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}