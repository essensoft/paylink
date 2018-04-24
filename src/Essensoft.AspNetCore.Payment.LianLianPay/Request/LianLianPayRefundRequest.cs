using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayRefundRequest : ILianLianPayRequest<LianLianPayRefundResponse>
    {
        /// <summary>
        /// 商户退款流水号
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 原商户订单号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 原商户订单时间
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 原连连银通支付单号
        /// </summary>
        public string OidPaybill { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        #region ILianLianPayRequest
        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/refund.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "no_refund", NoRefund },
                { "dt_refund", DtRefund },
                { "money_refund", MoneyRefund },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "oid_paybill", OidPaybill },
                { "notify_url", NotifyUrl },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return string.Empty;
        }

        public void SetApiVersion(string apiVersion)
        {
        }
        #endregion
    }
}
