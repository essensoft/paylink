using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse : AlipayResponse
    {
        /// <summary>
        /// 设备注册是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
