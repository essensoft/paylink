using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 分账 - 添加分账接收方 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayProfitSharingAddReceiverRequest : IWeChatPayRequest<WeChatPayProfitSharingAddReceiverResponse>
    {
        /// <summary>
        /// 品牌主商户号
        /// </summary>
        public string BrandMchId { get; set; }

        /// <summary>
        /// 分账接收方
        /// </summary>
        public string Receiver { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/profitsharingaddreceiver";
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
                { "brand_mch_id", BrandMchId },
                { "receiver", Receiver },
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
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(WeChatPayConsts.brand_mch_id)))
            {
                sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
