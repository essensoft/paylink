using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AreaInfo Data Structure.
    /// </summary>
    public class AreaInfo : AlipayObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
