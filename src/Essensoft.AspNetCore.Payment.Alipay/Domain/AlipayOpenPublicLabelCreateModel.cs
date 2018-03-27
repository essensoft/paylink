using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
