using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmServicerecordCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmServicerecordCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 服务记录ID
        /// </summary>
        [JsonPropertyName("service_record_id")]
        public string ServiceRecordId { get; set; }
    }
}
