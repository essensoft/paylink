using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainDataUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainDataUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 具体返回的处理结果
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }
    }
}
