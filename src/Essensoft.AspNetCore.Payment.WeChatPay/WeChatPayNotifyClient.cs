#if NETCOREAPP3_1

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.AspNetCore.Http;
using MD5 = Essensoft.AspNetCore.Payment.Security.MD5;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        #region WeChatPayNotifyClient Constructors

        public WeChatPayNotifyClient()
        {
        }

        #endregion

        #region IWeChatPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            var parser = new WeChatPayXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.Key).ToLowerInvariant();
                var data = AES.Decrypt((notify as WeChatPayRefundNotify).ReqInfo, key, CipherMode.ECB, PaddingMode.PKCS7);
                notify = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(notify, options);
            }

            return notify;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(WeChatPayNotify notify, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.ResponseBody))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (notify.ResponseParameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (!notify.ResponseParameters.TryGetValue("sign", out var sign))
            {
                throw new WeChatPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(notify.ResponseParameters, options.Key, WeChatPaySignType.MD5);
            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}

#endif
