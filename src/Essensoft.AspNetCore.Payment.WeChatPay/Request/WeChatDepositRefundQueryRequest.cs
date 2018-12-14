using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 酒店押金退款查询请求
    /// </summary>
    public class WeChatDepositRefundQueryRequest : WeChatPayRequest<WeChatDepositRefundQueryResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }
        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信退款单号
        /// </summary>
        public string RefundId { get; set; }

        #region IWeChatPayRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/deposit/refundquery";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_out_refund_no, OutRefundNo },
                { ConstKey.Key_refund_id, RefundId },
                { ConstKey.Key_sign_type,ConstKey.Key_HMAC_SHA256}
            };
            return parameters;
        }

        protected override void HandleSign(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(ConstKey.Key_sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, false, false));
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
            DoCheckResponseSign(response, options, false, false);
        }
        #endregion
    }
}
