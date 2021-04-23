using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 预订单状态 reverse_proc - 待确认 pay_succ- 已支付 refund_succ - 已退款 verified - 已核销 closed - 已关闭
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单应付金额（单位：元）
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [JsonPropertyName("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 订单商品信息列表
        /// </summary>
        [JsonPropertyName("product_group_list")]
        public List<ProductGroup> ProductGroupList { get; set; }

        /// <summary>
        /// 订单退款截止时间
        /// </summary>
        [JsonPropertyName("refund_end_time")]
        public string RefundEndTime { get; set; }

        /// <summary>
        /// 订单退款时间
        /// </summary>
        [JsonPropertyName("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 订单总金额（单位：元）
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
