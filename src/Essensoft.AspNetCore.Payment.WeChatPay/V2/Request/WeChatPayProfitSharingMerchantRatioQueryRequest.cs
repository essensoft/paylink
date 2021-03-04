using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 分账 - 查询订单最大分账比例 (服务商)
    /// </summary>
    public class WeChatPayProfitSharingMerchantRatioQueryRequest : IWeChatPayRequest<WeChatPayProfitSharingMerchantRatioQueryResponse>
    {
        /// <summary>
        /// 品牌主商户号
        /// </summary>
        public string BrandMchId { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/profitsharingmerchantratioquery";

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
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
