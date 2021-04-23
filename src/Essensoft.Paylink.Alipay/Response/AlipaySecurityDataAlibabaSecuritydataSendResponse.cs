using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataSendResponse.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataSendResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据写入后详细信息，一般为数据唯一key
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }
    }
}
