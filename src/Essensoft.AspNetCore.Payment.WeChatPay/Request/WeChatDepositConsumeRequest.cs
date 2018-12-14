using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 酒店押金消费接口请求
    /// </summary>
    public class WeChatDepositConsumeRequest : WeChatPayCertificateRequest<WeChatDepositConsumeResponse>
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

        /// <summary>
        /// 押金总金额
        /// </summary>
        public int TotalFee { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public int ConsumeFee { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string FeeType { get; set; }

        #region IWeChatPayRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/deposit/micropay";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_out_trade_no, OutTradeNo },
                { ConstKey.Key_transaction_id,TransactionId},
                { ConstKey.Key_total_fee, TotalFee },
                { ConstKey.Key_consume_fee,ConsumeFee},
                { ConstKey.Key_fee_type, FeeType },
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
