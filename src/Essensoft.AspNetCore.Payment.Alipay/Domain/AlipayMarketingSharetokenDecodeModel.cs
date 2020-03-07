using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingSharetokenDecodeModel Data Structure.
    /// </summary>
    public class AlipayMarketingSharetokenDecodeModel : AlipayObject
    {
        /// <summary>
        /// 码类型，可空，默认为吱口令类型『share_code』
        /// </summary>
        [JsonPropertyName("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 扩展属性，key-value json串
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 8位吱口令token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
