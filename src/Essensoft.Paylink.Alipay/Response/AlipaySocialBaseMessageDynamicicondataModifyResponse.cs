using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseMessageDynamicicondataModifyResponse.
    /// </summary>
    public class AlipaySocialBaseMessageDynamicicondataModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 此次操作结果
        /// </summary>
        [JsonPropertyName("op_result")]
        public bool OpResult { get; set; }
    }
}
