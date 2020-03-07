using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回主键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
