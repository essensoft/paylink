using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestCloudacptBatchQueryModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestCloudacptBatchQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// partener id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
