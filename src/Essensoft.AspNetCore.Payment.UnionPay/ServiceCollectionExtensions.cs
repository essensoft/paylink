using System;
using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;

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

        public static void AddUnionPayHttpClient(
            this IServiceCollection services)
        {
            services.AddHttpClient(UnionPayOptions.DefaultClientName);
        }
    }
}