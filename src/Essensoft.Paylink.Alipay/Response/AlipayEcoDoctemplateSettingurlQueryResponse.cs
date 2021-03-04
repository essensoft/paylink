using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoDoctemplateSettingurlQueryResponse.
    /// </summary>
    public class AlipayEcoDoctemplateSettingurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板设置地址
        /// </summary>
        [JsonPropertyName("setting_url")]
        public string SettingUrl { get; set; }
    }
}
