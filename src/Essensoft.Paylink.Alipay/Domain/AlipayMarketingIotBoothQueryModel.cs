using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingIotBoothQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingIotBoothQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端app信息，设备信息及sdk版本等信息加密后数据
        /// </summary>
        [JsonPropertyName("app_info")]
        public string AppInfo { get; set; }

        /// <summary>
        /// 支付宝付款码，dynamic_id_type选择bar_code时必填
        /// </summary>
        [JsonPropertyName("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// 支付码类型，可选bar_code、security_code
        /// </summary>
        [JsonPropertyName("dynamic_id_type")]
        public string DynamicIdType { get; set; }

        /// <summary>
        /// 刷脸成功返回的一次性消费码，dynamic_id_type选择security_code时必填
        /// </summary>
        [JsonPropertyName("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 商家活动ID
        /// </summary>
        [JsonPropertyName("merchant_plan_id")]
        public string MerchantPlanId { get; set; }

        /// <summary>
        /// IoT展位码
        /// </summary>
        [JsonPropertyName("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
