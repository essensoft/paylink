using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// StationDetailInfo Data Structure.
    /// </summary>
    public class StationDetailInfo : AlipayObject
    {
        /// <summary>
        /// 站点编码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 站点外部编码
        /// </summary>
        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }

        /// <summary>
        /// 站点中文名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
