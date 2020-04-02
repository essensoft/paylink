using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeOrderAggregateConsultModel Data Structure.
    /// </summary>
    public class KoubeiTradeOrderAggregateConsultModel : AlipayObject
    {
        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明
        /// </summary>
        [JsonPropertyName("goods_info")]
        public KbGoodsInfo GoodsInfo { get; set; }

        /// <summary>
        /// 外部订单号,商户下必须保持唯一，控制幂等
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单标题，报送至支付宝或微信
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 支付超时时间；默认3m; 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额； 若不可打折金额等于订单金额，则屏蔽营销
        /// </summary>
        [JsonPropertyName("un_discount_amount")]
        public string UnDiscountAmount { get; set; }
    }
}
