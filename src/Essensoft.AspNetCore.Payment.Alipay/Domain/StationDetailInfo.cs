using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StationDetailInfo Data Structure.
    /// </summary>
    public class StationDetailInfo : AlipayObject
    {
        /// <summary>
        /// 站点编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 站点外部编码
        /// </summary>
        [JsonPropertyName("ext_code")]
        public string ExtCode { get; set; }

        /// <summary>
        /// 站点中文名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
