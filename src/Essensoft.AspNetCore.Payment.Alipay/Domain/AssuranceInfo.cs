using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssuranceInfo Data Structure.
    /// </summary>
    public class AssuranceInfo : AlipayObject
    {
        /// <summary>
        /// 服务保障的描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务保障的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
