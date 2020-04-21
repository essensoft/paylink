using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommonBillQueryResponse.
    /// </summary>
    public class AlipayEbppCommonBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝账单流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 出账机构英文缩写
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构英文缩写
        /// </summary>
        [JsonPropertyName("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 订单扩展信息
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 订单创建时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单支付时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// S-成功 P-已支付 I-待支付 C-已关闭 T-退款中 F-已退款
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
