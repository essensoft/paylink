using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceInitializeResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDeviceInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
