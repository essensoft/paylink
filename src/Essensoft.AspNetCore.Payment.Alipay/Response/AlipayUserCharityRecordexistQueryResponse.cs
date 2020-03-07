using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCharityRecordexistQueryResponse.
    /// </summary>
    public class AlipayUserCharityRecordexistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有过捐赠记录(有:true,否:false)
        /// </summary>
        [JsonPropertyName("donation_tag")]
        public bool DonationTag { get; set; }

        /// <summary>
        /// 爱心捐赠平台捐赠的次数
        /// </summary>
        [JsonPropertyName("donation_times")]
        public long DonationTimes { get; set; }
    }
}
