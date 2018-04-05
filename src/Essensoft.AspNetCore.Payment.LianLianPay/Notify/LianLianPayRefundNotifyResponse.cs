using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    public class LianLianPayRefundNotifyResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 商户编号
        /// 商户编号是商户在连连支付支付平台上开 设的商户号码，为18位数字，如： 201304121000001004 
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// RSA加密签名，见安全签名机制 订单信息 
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 商户退款流水号
        /// 商户系统唯一标识该退款的流水号
        /// </summary>
        [JsonProperty("no_refund")]
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// 格式：YYYYMMDDH24MISS 14 位数字，精确到秒
        /// </summary>
        [JsonProperty("dt_refund")]
        public string DtRefund { get; set; }

        /// <summary>
        /// 退款金额
        /// 退款金额，该金额必须小于或等于原订单金额，单位为 RMB-元。大于 0 的数字，精确到小数点后两位。如：49.65
        /// </summary>
        [JsonProperty("money_refund")]
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 连连银通退款流水号
        /// 银通退款流水号
        /// </summary>
        [JsonProperty("oid_refundno")]
        public string OidRefundNo { get; set; }

        /// <summary>
        /// 退款状态
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
