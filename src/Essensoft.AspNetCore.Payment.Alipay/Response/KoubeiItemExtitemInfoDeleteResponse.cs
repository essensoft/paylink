using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除成功，返回主键id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
