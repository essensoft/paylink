using System;
using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLianLianPay(
            this IServiceCollection services)
        {
            services.AddLianLianPay(setupAction: null);
        }

        public static void AddLianLianPay(
            this IServiceCollection services,
            Action<LianLianPayOptions> setupAction)
        {
            services.AddSingleton<LianLianPayClient>();
            services.AddSingleton<LianLianPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }

        public static void AddLianLianPayHttpClient(
            this IServiceCollection services)
        {
            services.AddHttpClient(LianLianPayOptions.DefaultClientName);
        }
    }
}