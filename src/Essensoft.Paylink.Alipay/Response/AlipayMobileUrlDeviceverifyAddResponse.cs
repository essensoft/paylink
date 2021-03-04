using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMobileUrlDeviceverifyAddResponse.
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddResponse : AlipayResponse
    {
        /// <summary>
        /// 返回业务操作是否成功
        /// </summary>
        [JsonPropertyName("response")]
        public bool Response { get; set; }
    }
}
