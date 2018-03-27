using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduSourceInfo Data Structure.
    /// </summary>
    public class EduSourceInfo : AlipayObject
    {
        /// <summary>
        /// 供应商的LOGO
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 供应商电话
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 供应商名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
