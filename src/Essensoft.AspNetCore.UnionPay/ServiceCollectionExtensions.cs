using Essensoft.AspNetCore.UnionPay;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUnionPay(
            this IServiceCollection services)
        {
            services.AddUnionPay(setupAction: null);
        }

        public static void AddUnionPay(
            this IServiceCollection services,
            Action<UnionPayOptions> setupAction)
        {
            services.AddSingleton<UnionPayClient>();
            services.AddSingleton<UnionPayNotifyClient>();
            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}