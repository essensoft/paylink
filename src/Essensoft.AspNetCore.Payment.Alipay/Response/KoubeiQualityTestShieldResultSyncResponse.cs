using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldResultSyncResponse.
    /// </summary>
    public class KoubeiQualityTestShieldResultSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
