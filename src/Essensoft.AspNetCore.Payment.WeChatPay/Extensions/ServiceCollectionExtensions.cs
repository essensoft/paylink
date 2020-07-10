using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(this IServiceCollection services)
        {
            services.AddHttpClient(Essensoft.AspNetCore.Payment.WeChatPay.V2.WeChatPayClient.Name);
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, Essensoft.AspNetCore.Payment.WeChatPay.V2.WeChatPayHttpMessageHandlerBuilderFilter>());
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V2.WeChatPayClientCertificateManager>();
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V2.IWeChatPayClient, Essensoft.AspNetCore.Payment.WeChatPay.V2.WeChatPayClient>();
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V2.IWeChatPayNotifyClient, Essensoft.AspNetCore.Payment.WeChatPay.V2.WeChatPayNotifyClient>();

            services.AddHttpClient(Essensoft.AspNetCore.Payment.WeChatPay.V3.WeChatPayClient.Name);
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V3.WeChatPayPlatformCertificateManager>();
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V3.IWeChatPayClient, Essensoft.AspNetCore.Payment.WeChatPay.V3.WeChatPayClient>();
            services.AddSingleton<Essensoft.AspNetCore.Payment.WeChatPay.V3.IWeChatPayNotifyClient, Essensoft.AspNetCore.Payment.WeChatPay.V3.WeChatPayNotifyClient>();
        }
    }
}
