using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SenderInfoVO Data Structure.
    /// </summary>
    public class SenderInfoVO : AlipayObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonPropertyName("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 发货人电话
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 发货人
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
