using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UnfreezeOrderDetail Data Structure.
    /// </summary>
    public class UnfreezeOrderDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 冻结订单的商户订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单的最近修改时间
        /// </summary>
        [JsonPropertyName("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 冻结金额（含服务费）
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单状态：I：初始，S：成功，F：失败
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 解冻金额（含服务费）
        /// </summary>
        [JsonPropertyName("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }
    }
}
