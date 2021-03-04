using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampModifyResponse.
    /// </summary>
    public class AlipayOpenLotteryCampModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动ID
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
