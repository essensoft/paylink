using Newtonsoft.Json;

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
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 外部单元编号
        /// </summary>
        [JsonProperty("group_outer_id")]
        public string GroupOuterId { get; set; }
    }
}
