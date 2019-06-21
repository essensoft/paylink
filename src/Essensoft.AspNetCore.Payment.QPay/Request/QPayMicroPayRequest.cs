using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;
using Essensoft.AspNetCore.Payment.QPay.Utility;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 提交付款码支付
    /// </summary>
    public class QPayMicroPayRequest : IQPayRequest<QPayMicroPayResponse>
    {
        /// <summary>
        /// 子商户应用ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 货币类型定义
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpBillCreateIp { get; set; }

        /// <summary>
        /// 支付方式限制
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// QQ钱包活动标识
        /// </summary>
        public string PromotionTag { get; set; }

        /// <summary>
        /// 支付结果通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 用户的付款码
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// 支付场景
        /// </summary>
        public string TradeType { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_micro_pay.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "body", Body },
                { "attach", Attach },
                { "out_trade_no", OutTradeNo },
                { "fee_type", FeeType },
                { "total_fee", TotalFee },
                { "spbill_create_ip", SpBillCreateIp },
                { "limit_pay", LimitPay },
                { "promotion_tag", PromotionTag },
                { "notify_url", NotifyUrl },
                { "device_info", DeviceInfo },
                { "auth_code", AuthCode },
                { "trade_type", TradeType }
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(QPayConsts.NONCE_STR, QPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(QPayConsts.APPID, options.AppId);
            sortedTxtParams.Add(QPayConsts.MCH_ID, options.MchId);

            sortedTxtParams.Add(QPayConsts.SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
        }

        public bool GetNeedCheckSign()
        {
            return true;
        }

        #endregion
    }
}
