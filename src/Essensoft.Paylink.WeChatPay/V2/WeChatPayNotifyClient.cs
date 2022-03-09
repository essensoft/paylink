﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.Paylink.Security;
using Essensoft.Paylink.WeChatPay.V2.Parser;
using MD5 = Essensoft.Paylink.Security.MD5;

namespace Essensoft.Paylink.WeChatPay.V2
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        #region WeChatPayNotifyClient Constructors

        public WeChatPayNotifyClient()
        {
        }

        #endregion

        #region IWeChatPayNotifyClient Members

#if NETCOREAPP3_1_OR_GREATER
        public async Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                var body = await reader.ReadToEndAsync();
                return await ExecuteAsync<T>(body, options);
            }
        }
#endif

        #endregion

        #region IWeChatPayNotifyClient Members

        public Task<T> ExecuteAsync<T>(string body, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIKey)} is Empty!");
            }

            var parser = new WeChatPayNotifyXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is Notify.WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.APIKey).ToLowerInvariant();
                var data = AES.Decrypt((notify as Notify.WeChatPayRefundNotify).ReqInfo, key, CipherMode.ECB, PaddingMode.PKCS7);
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

        private static void CheckNotifySign(WeChatPayNotify notify, WeChatPayOptions options)
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

            string cal_sign;
            if (notify.Parameters.TryGetValue("sign_type", out var sign_type) && sign_type == WeChatPayConsts.HMAC_SHA256)
            {
                cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.APIKey, WeChatPaySignType.HMAC_SHA256);
            }
            else
            {
                cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.APIKey, WeChatPaySignType.MD5);
            }

            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
