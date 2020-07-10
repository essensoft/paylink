using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser;
using MD5 = Essensoft.AspNetCore.Payment.Security.MD5;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        #region WeChatPayNotifyClient Constructors

        public WeChatPayNotifyClient()
        {
        }

        #endregion

        #region IWeChatPayNotifyClient Members

#if NETCOREAPP3_1
        public async Task<T> ExecuteV2Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : V2.WeChatPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            return await ExecuteV2Async<T>(body, options);
        }
#endif

        #endregion

        #region IWeChatPayNotifyClient Members

        public Task<T> ExecuteV2Async<T>(string body, WeChatPayOptions options) where T : V2.WeChatPayNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var parser = new WeChatPayNotifyXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is V2.Notify.WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.Key).ToLowerInvariant();
                var data = AES.Decrypt((notify as V2.Notify.WeChatPayRefundNotify).ReqInfo, key, CipherMode.ECB, PaddingMode.PKCS7);
                notify = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(notify, options);
            }

            return Task.FromResult(notify);
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(V2.WeChatPayNotify notify, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (notify.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (!notify.Parameters.TryGetValue("sign", out var sign))
            {
                throw new WeChatPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.Key, WeChatPaySignType.MD5);
            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
