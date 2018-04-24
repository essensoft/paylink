using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    public class LianLianPayRefundNotifyResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 商户编号
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
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 商户退款流水号
        /// </summary>
        [JsonProperty("no_refund")]
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// </summary>
        [JsonProperty("dt_refund")]
        public string DtRefund { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("money_refund")]
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 连连银通退款流水号
        /// </summary>
        [JsonProperty("oid_refundno")]
        public string OidRefundNo { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [JsonProperty("sta_refund")]
        public string StaRefund { get; set; }

        /// <summary>
        /// 清算日期
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }
    }
}
