using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoPrinterStatusQueryResponse.
    /// </summary>
    public class AlipayEcoPrinterStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 0离线 1在线 2缺纸
        /// </summary>
        [JsonPropertyName("state")]
        public long State { get; set; }
    }
}
