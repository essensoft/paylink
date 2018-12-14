using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 酒店押金撤销
    /// 调用支付接口后请勿立即调用撤销订单 API，建议支付后至少 15s 后再调用撤销订单接口
    /// </summary>
    public class WeChatDepositReverseRequest : WeChatPayCertificateRequest<WeChatDepositReverseResponse>
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
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/deposit/reverse";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_transaction_id, TransactionId },
                { ConstKey.Key_out_trade_no, OutTradeNo },
                { ConstKey.Key_sign_type, ConstKey.Key_HMAC_SHA256 }
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
