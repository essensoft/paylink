using Essensoft.AspNetCore.JdPay;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddJdPay(
            this IServiceCollection services)
        {
            services.AddJdPay(setupAction: null);
        }

        public static void AddJdPay(
            this IServiceCollection services,
            Action<JdPayOptions> setupAction)
        {
            services.AddSingleton<JdPayClient>();
            services.AddSingleton<JdPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}