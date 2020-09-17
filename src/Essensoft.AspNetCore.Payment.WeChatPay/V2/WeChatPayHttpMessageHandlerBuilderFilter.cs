using System;
using System.Net.Http;
using Microsoft.Extensions.Http;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    public class WeChatPayHttpMessageHandlerBuilderFilter : IHttpMessageHandlerBuilderFilter
    {
        private readonly WeChatPayClientCertificateManager _clientCertificateManager;

        public WeChatPayHttpMessageHandlerBuilderFilter(WeChatPayClientCertificateManager clientCertificateManager)
        {
            _clientCertificateManager = clientCertificateManager;
        }

        public Action<HttpMessageHandlerBuilder> Configure(Action<HttpMessageHandlerBuilder> next)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            return (builder) =>
            {
                next(builder);

                if (builder.PrimaryHandler is HttpClientHandler handler)
                {
                    if (builder.Name.Contains(WeChatPayClient.Prefix))
                    {
                        var certificateSerialNo = builder.Name.RemovePreFix(WeChatPayClient.Prefix);
                        if (_clientCertificateManager.TryGetValue(certificateSerialNo, out var clientCertificate))
                        {
                            handler.ClientCertificates.Add(clientCertificate);
                        }
                    }
                }
            };
        }
    }
}
