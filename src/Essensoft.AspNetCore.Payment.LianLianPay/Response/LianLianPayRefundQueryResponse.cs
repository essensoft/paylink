using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    public class LianLianPayRefundQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 交易结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 交易结果描述
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
        /// 商户编号
        /// 商户编号是商户在连连支付支付平台上开设的商 户号 码，为 18 位 数字， 如：201304121000001004
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 商户退款流水号
        /// 商户系统唯一标识该退款的流水号
        /// </summary>
        [JsonProperty("no_refund")]
        public string NoRefund { get; set; }

        /// <summary>
        /// 退款金额
        /// 退款金额，该金额必须小于或等于原订单金额，单位为 RMB-元。大于 0 的数字，精确到小数点后两位。如：49.65
        /// </summary>
        [JsonProperty("money_refund")]
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 连连银通退款流水号
        /// </summary>
        [JsonProperty("oid_refundno")]
        public string OidRefundno { get; set; }

        /// <summary>
        /// 退款状态
        /// 退款申请: 0
        /// 退款处理中：1
        /// 退款成功：2
        /// 退款失败：3
        /// </summary>
        [JsonProperty("sta_refund")]
        public string StaRefund { get; set; }

        /// <summary>
        /// 清算日期
        /// 退货成功时返回
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }
    }
}
