using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelModifyModel : AlipayObject
    {
        /// <summary>
        /// 要修改的标签id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 要修改成的标签名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
