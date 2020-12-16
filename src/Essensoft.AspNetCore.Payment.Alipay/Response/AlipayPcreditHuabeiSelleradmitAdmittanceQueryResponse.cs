using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitAdmittanceQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitAdmittanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 不准入原因
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求场景，id集合，拼接
        /// </summary>
        [JsonPropertyName("request_key")]
        public string RequestKey { get; set; }
    }
}
