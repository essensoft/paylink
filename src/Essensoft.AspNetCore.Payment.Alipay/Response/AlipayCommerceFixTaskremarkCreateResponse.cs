using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskremarkCreateResponse.
    /// </summary>
    public class AlipayCommerceFixTaskremarkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功的备注id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
