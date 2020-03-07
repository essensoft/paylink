using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoDynamicinfoAddResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AlipayResponse
    {
        /// <summary>
        /// 同步处理结果
        /// </summary>
        [JsonPropertyName("operateresult")]
        public bool Operateresult { get; set; }
    }
}
