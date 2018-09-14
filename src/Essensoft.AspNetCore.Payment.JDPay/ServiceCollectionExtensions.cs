using System;
using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.JDPay.Utility;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddJDPay(
            this IServiceCollection services)
        {
            services.AddJDPay(setupAction: null);
        }

        public static void AddJDPay(
            this IServiceCollection services,
            Action<JDPayOptions> setupAction)
        {
            services.AddSingleton<JDPayClient>();
            services.AddSingleton<JDPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }

        public static void AddJDPayHttpClient(
            this IServiceCollection services)
        {
            services.AddHttpClient(JDPayUtility.DefaultClientName);
        }
    }
}