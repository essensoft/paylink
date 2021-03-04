using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDataPutResponse.
    /// </summary>
    public class AlipayEcapiprodDataPutResponse : AlipayResponse
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }
    }
}
