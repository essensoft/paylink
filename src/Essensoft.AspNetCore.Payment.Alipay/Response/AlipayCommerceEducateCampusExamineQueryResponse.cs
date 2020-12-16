using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusExamineQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusExamineQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 审核未通过原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
