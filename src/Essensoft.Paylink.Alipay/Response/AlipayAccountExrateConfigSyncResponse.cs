using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateConfigSyncResponse.
    /// </summary>
    public class AlipayAccountExrateConfigSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步到主站的配置的bcode信息
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }
    }
}
