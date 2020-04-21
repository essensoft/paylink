using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestCloudacptItemQueryModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestCloudacptItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// partener id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
