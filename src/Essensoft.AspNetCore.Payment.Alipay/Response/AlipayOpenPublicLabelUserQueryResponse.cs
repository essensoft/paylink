using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户标签id列表，以英文逗号分隔
        /// </summary>
        [JsonPropertyName("label_ids")]
        public string LabelIds { get; set; }
    }
}
