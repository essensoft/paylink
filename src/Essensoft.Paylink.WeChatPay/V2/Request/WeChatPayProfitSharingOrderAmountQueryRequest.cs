using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 分账 - 查询订单待分账金额 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayProfitSharingOrderAmountQueryRequest : IWeChatPayRequest<WeChatPayProfitSharingOrderAmountQueryResponse>
    {
        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/profitsharingorderamountquery";
        private WeChatPaySignType signType = WeChatPaySignType.HMAC_SHA256;

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "transaction_id", TransactionId },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return signType;
        }

        public void SetSignType(WeChatPaySignType signType)
        {
            this.signType = signType switch
            {
                WeChatPaySignType.HMAC_SHA256 => signType,
                _ => throw new WeChatPayException("api only support HMAC_SHA256!"),
            };
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
