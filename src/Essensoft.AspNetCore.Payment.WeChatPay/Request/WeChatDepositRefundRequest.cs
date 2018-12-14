using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 酒店押金退款请求
    /// </summary>
    public class WeChatDepositRefundRequest : WeChatPayCertificateRequest<WeChatDepositRefundResponse>
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
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }
        /// <summary>
        /// 押金退款单号
        /// </summary>
        public string OutRefundNo { get; set; }
        /// <summary>
        /// 押金总金额
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
        public int RefundDesc { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        public string RefundAccount { get; set; }

        #region IWeChatPayRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/deposit/refund";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_transaction_id,TransactionId},
                { ConstKey.Key_out_refund_no,OutRefundNo},
                { ConstKey.Key_total_fee, TotalFee },
                { ConstKey.Key_refund_fee,RefundFee},
                { ConstKey.Key_refund_fee_type, RefundFeeType },
                { ConstKey.Key_refund_desc,RefundDesc},
                { ConstKey.Key_refund_account, RefundAccount },
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
