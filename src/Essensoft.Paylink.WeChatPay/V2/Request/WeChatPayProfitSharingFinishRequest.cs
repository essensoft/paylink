using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 分账 - 完结分账 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayProfitSharingFinishRequest : IWeChatPayCertRequest<WeChatPayProfitSharingFinishResponse>
    {
        /// <summary>
        /// 品牌主商户号
        /// </summary>
        public string BrandMchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分账完结描述
        /// </summary>
        public string Description { get; set; }

        #region IWeChatPayCertRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/secapi/pay/profitsharingfinish";
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
                { "transaction_id", TransactionId },
                { "out_order_no", OutOrderNo },
                { "description", Description },
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
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
