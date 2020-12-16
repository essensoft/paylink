using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIstdstatusSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillIstdstatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 事件发生时间点
        /// </summary>
        [JsonPropertyName("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 预计还剩多久送达，单位：秒
        /// </summary>
        [JsonPropertyName("reach_duration")]
        public long ReachDuration { get; set; }

        /// <summary>
        /// 骑手电话
        /// </summary>
        [JsonPropertyName("rider_mobile_no")]
        public string RiderMobileNo { get; set; }

        /// <summary>
        /// 骑手姓名
        /// </summary>
        [JsonPropertyName("rider_name")]
        public string RiderName { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

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
