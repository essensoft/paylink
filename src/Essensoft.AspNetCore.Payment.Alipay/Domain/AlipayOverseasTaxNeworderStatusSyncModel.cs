using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxNeworderStatusSyncModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxNeworderStatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 纸质退税单号
        /// </summary>
        [JsonPropertyName("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 扩展参数json格式
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 当前状态，海关已盖章（STAMPED），海关拒绝（REJECTED_BY_CUSTOMS），退税机构收到退税单（RECEIVED），作废（VOIDED），失败（FAILED），过期（EXPIRED），已退税（REFUNDED），已使用非支付宝退税（REFUNDED_NON_ALIPAY）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 当前状态发生变更的时间(UTC+8)，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("status_change_time")]
        public string StatusChangeTime { get; set; }

        /// <summary>
        /// 当前状态要给用户的提示信息
        /// </summary>
        [JsonPropertyName("status_msg")]
        public string StatusMsg { get; set; }

        /// <summary>
        /// 支付宝退税单号
        /// </summary>
        [JsonPropertyName("tax_order_no")]
        public string TaxOrderNo { get; set; }

        /// <summary>
        /// 支付宝资金订单号，预授权退税下单接口返回的tax_refund_no，原单笔退税接口返回的refund_order_no，批量退税结果文件倒数第二列。当且status为REFUNDED时必选，其余状态忽略
        /// </summary>
        [JsonPropertyName("tax_payment_no")]
        public string TaxPaymentNo { get; set; }
    }
}
