using System;
using System.Net.Http;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Http;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayHandlerBuilderFilter : IHttpMessageHandlerBuilderFilter
    {
        private readonly QPayCertificateManager _certificateManager;

        public QPayHandlerBuilderFilter(QPayCertificateManager certificateManager)
        {
            _certificateManager = certificateManager;
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
                    if (builder.Name.Contains(QPayClient.Prefix))
                    {
                        var hash = builder.Name.RemovePreFix(QPayClient.Prefix);
                        if (_certificateManager.TryGet(hash, out var certificate))
                        {
                            handler.ClientCertificates.Add(certificate);
                        }
                    }
                }
            };
        }
    }
}
