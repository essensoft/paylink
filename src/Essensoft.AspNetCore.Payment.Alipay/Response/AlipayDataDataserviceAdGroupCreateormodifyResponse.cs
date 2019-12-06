using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 外部单元编号
        /// </summary>
        [JsonPropertyName("group_outer_id")]
        public string GroupOuterId { get; set; }
    }
}
