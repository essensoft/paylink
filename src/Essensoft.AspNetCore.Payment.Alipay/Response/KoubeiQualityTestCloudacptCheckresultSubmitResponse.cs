using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptCheckresultSubmitResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptCheckresultSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }
    }
}
