using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderExtIstd Data Structure.
    /// </summary>
    public class OrderExtIstd : AlipayObject
    {
        /// <summary>
        /// 骑手应付金额
        /// </summary>
        [JsonPropertyName("cash_on_delivery")]
        public string CashOnDelivery { get; set; }

        /// <summary>
        /// 骑手应收金额
        /// </summary>
        [JsonPropertyName("cash_on_pickup")]
        public string CashOnPickup { get; set; }

        /// <summary>
        /// 消费者下单时间
        /// </summary>
        [JsonPropertyName("consumer_order_time")]
        public string ConsumerOrderTime { get; set; }

        /// <summary>
        /// 物流流向，1：从门店取件送至用户；2：从用户取件送至门店
        /// </summary>
        [JsonPropertyName("delivery_direction")]
        public long DeliveryDirection { get; set; }

        /// <summary>
        /// 配送类型, 0: 即时单 1 预约单
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public long DeliveryType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 期望派单时间
        /// </summary>
        [JsonPropertyName("expected_delivery_time")]
        public string ExpectedDeliveryTime { get; set; }

        /// <summary>
        /// 期望送达时间
        /// </summary>
        [JsonPropertyName("expected_finish_time")]
        public string ExpectedFinishTime { get; set; }

        /// <summary>
        /// 期望取件时间
        /// </summary>
        [JsonPropertyName("expected_pick_time")]
        public string ExpectedPickTime { get; set; }

        /// <summary>
        /// 保价金额
        /// </summary>
        [JsonPropertyName("insure_price")]
        public string InsurePrice { get; set; }

        /// <summary>
        /// 是否直拿直送，1:直拿直送 0:非直拿直送
        /// </summary>
        [JsonPropertyName("is_direct_delivery")]
        public long IsDirectDelivery { get; set; }

        /// <summary>
        /// 是否需要收货码，1:需要 0:不需要
        /// </summary>
        [JsonPropertyName("is_finish_code_needed")]
        public long IsFinishCodeNeeded { get; set; }

        /// <summary>
        /// 是否保价，1:保价 0:不保价
        /// </summary>
        [JsonPropertyName("is_insured")]
        public long IsInsured { get; set; }

        /// <summary>
        /// 是否需要取货码，1:需要 0:不需要
        /// </summary>
        [JsonPropertyName("is_pickup_code_needed")]
        public long IsPickupCodeNeeded { get; set; }

        /// <summary>
        /// 门店订单流水号
        /// </summary>
        [JsonPropertyName("poi_seq")]
        public string PoiSeq { get; set; }
    }
}
