using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskHideDeviceidQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHideDeviceidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备指纹的apdid
        /// </summary>
        [JsonPropertyName("deviceid")]
        public string Deviceid { get; set; }
    }
}
