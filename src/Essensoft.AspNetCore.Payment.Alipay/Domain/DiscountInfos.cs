using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountInfos Data Structure.
    /// </summary>
    public class DiscountInfos : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 本次支付商家优惠的金额
        /// </summary>
        [JsonPropertyName("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 本次支付平台补贴的金额
        /// </summary>
        [JsonPropertyName("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
