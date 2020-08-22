using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 酒店押金 - 申请退款 (服务商)
    /// </summary>
    public class WeChatPayDepositRefundRequest : IWeChatPayCertRequest<WeChatPayDepositRefundResponse>
    {
        /// <summary>
        /// 微信支付订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 押金退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 申请退款金额
        /// </summary>
        public int RefundFee { get; set; }

        /// <summary>
        /// 退款货币种类
        /// </summary>
        public string RefundFeeType { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        public string RefundAccount { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/deposit/refund";

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
                { "out_refund_no", OutRefundNo },
                { "total_fee", TotalFee },
                { "refund_fee", RefundFee },
                { "refund_fee_type", RefundFeeType },
                { "refund_desc", RefundDesc },
                { "refund_account", RefundAccount },
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
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
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
