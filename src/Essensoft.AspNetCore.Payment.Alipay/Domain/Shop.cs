using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Shop Data Structure.
    /// </summary>
    public class Shop : AlipayObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店类型，只能选择SMID/MID/PID其中一个
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
