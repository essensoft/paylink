using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdDeviceinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdDeviceinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// device_info，查询返回的设备数据字段JSON字符串
        /// </summary>
        [JsonPropertyName("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// risk_info，查询返回的设备风险字段JSON字符串
        /// </summary>
        [JsonPropertyName("risk_info")]
        public string RiskInfo { get; set; }
    }
}
