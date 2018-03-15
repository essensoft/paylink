using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingExtData Data Structure.
    /// </summary>
    public class AlipayMarketingExtData : AlipayObject
    {
        /// <summary>
        /// 复杂模型
        /// </summary>
        [JsonProperty("lbs_info")]
        public AlipayMarketingIbsInfo LbsInfo { get; set; }

        /// <summary>
        /// 外部uid
        /// </summary>
        [JsonProperty("out_user_id")]
        public string OutUserId { get; set; }
    }
}
