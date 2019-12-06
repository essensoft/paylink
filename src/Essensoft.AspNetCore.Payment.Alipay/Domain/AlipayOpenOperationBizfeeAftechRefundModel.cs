using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechRefundModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechRefundModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 退费币种 币种数字编码。
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 费用订单号
        /// </summary>
        [JsonPropertyName("fee_order_no")]
        public string FeeOrderNo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退费金额 单位元，最多两位小数。
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退费流水号
        /// </summary>
        [JsonPropertyName("refund_no")]
        public string RefundNo { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
