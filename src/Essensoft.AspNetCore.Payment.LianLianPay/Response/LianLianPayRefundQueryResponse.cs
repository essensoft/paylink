using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 退款订单查询
    /// </summary>
    public class LianLianPayRefundQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 请求结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 请求结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 商户编号是商户在连连支付支付平台上开设的商户号码，为18位数字，如：201304121000001004。
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 原请求中商户退款流水号。
        /// </summary>
        [JsonProperty("no_refund")]
        public string NoRefund { get; set; }

        /// <summary>
        /// 原请求中退款金额。
        /// </summary>
        [JsonProperty("money_refund")]
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 连连退款流水号，全局唯一。
        /// </summary>
        [JsonProperty("oid_refundno")]
        public string OidRefundno { get; set; }

        /// <summary>
        /// 退款单的退款状态，详情参考退款类订单状态说明。
        /// 0 - 退款申请。
        /// 1 - 退款处理中。
        /// 2 - 退款成功。
        /// 3 - 退款失败。
        /// </summary>
        [JsonProperty("sta_refund")]
        public string StaRefund { get; set; }

        /// <summary>
        /// 清算日期。格式：YYYYMMDD。
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }
    }
}
