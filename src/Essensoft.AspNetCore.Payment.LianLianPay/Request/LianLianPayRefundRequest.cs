using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayRefundRequest : ILianLianPayRequest<LianLianPayRefundResponse>
    {
        /// <summary>
        /// 商户退款流水号
        /// 商户系统唯一标识该退款的流水号
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// 签约协议号 协议号和银行卡号选择一个填写
        /// 格式：YYYYMMDDH24MISS 14 位数字，精确到秒
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 退款金额
        /// 退款金额，该金额必须小于或等于原订单金额， 单位为 RMB-元。 大于 0 的数字，精确到小数点后两位。 如：49.65
        /// </summary>
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 原商户订单号
        /// 原商户订单号和连连银通支付单号oid_paybill，这两个必须提供一个作为退原单的标识
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 原商户订单时间
        /// 原商户订单号、原订单时间和连连银通支付单号 oid_paybill，这两个必须提供一个作为退原单的标识，格式：YYYYMMDDH24MISS 14位数字，精确到秒
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 原连连银通支付单号
        /// 原订单对应的连连银通支付单号
        /// </summary>
        public string OidPaybill { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// 连连支付支付平台在退款后通知商户服务端的地址，如：http://payhttp.xiaofubao.com/***/back.shtml
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
