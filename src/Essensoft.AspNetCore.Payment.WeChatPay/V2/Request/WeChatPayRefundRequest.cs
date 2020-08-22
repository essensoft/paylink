using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 申请退款 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayRefundRequest : IWeChatPayCertRequest<WeChatPayRefundResponse>
    {
        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户退款单号
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

        /// <summary>
        /// 退款结果通知url
        /// </summary>
        public string NotifyUrl { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/secapi/pay/refund";

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
                { "out_trade_no", OutTradeNo },
                { "out_refund_no", OutRefundNo },
                { "total_fee", TotalFee },
                { "refund_fee", RefundFee },
                { "refund_fee_type", RefundFeeType },
                { "refund_desc", RefundDesc },
                { "refund_account", RefundAccount },
                { "notify_url", NotifyUrl }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
