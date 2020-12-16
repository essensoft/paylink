using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceItaskMerchantRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskMerchantRecordSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 业务入参的biz_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
