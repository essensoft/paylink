using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// PublicLabel Data Structure.
    /// </summary>
    public class PublicLabel : AlipayObject
    {
        /// <summary>
        /// 标签用户量
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
