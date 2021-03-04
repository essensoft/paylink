using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataAntlogmngActivitypagespmCreateResponse.
    /// </summary>
    public class AlipayMarketingDataAntlogmngActivitypagespmCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请是否成功
        /// </summary>
        [JsonPropertyName("issuc")]
        public bool Issuc { get; set; }

        /// <summary>
        /// 描述业务状态
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
