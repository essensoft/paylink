using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 分账 - 分账回退 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayProfitSharingReturnRequest : IWeChatPayCertRequest<WeChatPayProfitSharingReturnResponse>
    {
        /// <summary>
        /// 微信分账单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户回退单号
        /// </summary>
        public string OutReturnNo { get; set; }

        /// <summary>
        /// 回退方类型
        /// </summary>
        public string ReturnAccountType { get; set; }

        /// <summary>
        /// 回退方账号
        /// </summary>
        public string ReturnAccount { get; set; }

        /// <summary>
        /// 回退金额
        /// </summary>
        public int ReturnAmount { get; set; }

        /// <summary>
        /// 回退描述
        /// </summary>
        public string Description { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/secapi/pay/profitsharingreturn";

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
                { "order_id", OrderId },
                { "out_order_no", OutOrderNo },
                { "out_return_no", OutReturnNo },
                { "return_account_type", ReturnAccountType },
                { "return_account", ReturnAccount },
                { "return_amount", ReturnAmount },
                { "description", Description },
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
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
