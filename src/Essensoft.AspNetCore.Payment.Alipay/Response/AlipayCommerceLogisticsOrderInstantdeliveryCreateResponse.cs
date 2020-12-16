using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderInstantdeliveryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 优惠券费用
        /// </summary>
        [JsonPropertyName("coupon_fee")]
        public string CouponFee { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        [JsonPropertyName("deliver_fee")]
        public string DeliverFee { get; set; }

        /// <summary>
        /// 预计骑手还剩多久接单，单位：秒
        /// </summary>
        [JsonPropertyName("dispatch_duration")]
        public long DispatchDuration { get; set; }

        /// <summary>
        /// 配送距离
        /// </summary>
        [JsonPropertyName("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 实际运费
        /// </summary>
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 收货码，骑手必须输入收货码才能完成订单妥投
        /// </summary>
        [JsonPropertyName("finish_code")]
        public string FinishCode { get; set; }

        /// <summary>
        /// 保价费用
        /// </summary>
        [JsonPropertyName("insurance_fee")]
        public string InsuranceFee { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额, 实际扣减的费用以此字段为准
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 取货码, 骑手必须输入取货码才能从商家取货
        /// </summary>
        [JsonPropertyName("pickup_code")]
        public string PickupCode { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
