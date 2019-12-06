using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
