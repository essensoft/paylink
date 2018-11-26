using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 退款
    /// </summary>
    public class LianLianPayRefundRequest : ILianLianPayRequest<LianLianPayRefundResponse>
    {
        /// <summary>
        /// 商户退款流水号。
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 原退款请求中money_refund对应的订单总金额，单位为元，精确到小数点后两位，小数点计入字符长度。
        /// 取值范围为 0.01 ~ 99999999。
        /// </summary>
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 原收款请求中传入的商户订单号NoOrder。
        /// NoOrder + DtOrder 或 OidPaybill 必须提供一个作为退款单标识。
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 原商户订单时间
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// NoOrder + DtOrder 或 OidPaybill 必须提供一个作为退款单标识。
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 连连收款单号。全局唯一。如： 2011030900001098。
        /// NoOrder + DtOrder 或 OidPaybill 必须提供一个作为退款单标识。
        /// </summary>
        public string OidPaybill { get; set; }

        /// <summary>
        /// 接收异步通知的线上地址。
        /// 连连支付支付平台在用户支付成功后通知商户服务端的地址。
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
                { "notify_url", NotifyUrl }
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            throw new NotImplementedException();
        }

        public void SetApiVersion(string apiVersion)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
