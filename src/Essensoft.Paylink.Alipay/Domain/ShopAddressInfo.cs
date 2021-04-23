using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ShopAddressInfo Data Structure.
    /// </summary>
    public class ShopAddressInfo : AlipayObject
    {
        /// <summary>
        /// 精度类型，支付宝定义code
        /// </summary>
        [JsonPropertyName("accuracy_type")]
        public string AccuracyType { get; set; }

        /// <summary>
        /// 地址详情
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonPropertyName("county")]
        public string County { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
