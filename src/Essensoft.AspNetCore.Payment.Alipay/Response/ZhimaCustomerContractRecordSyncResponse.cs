using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerContractRecordSyncResponse.
    /// </summary>
    public class ZhimaCustomerContractRecordSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 本次存证记录的唯一标识
        /// </summary>
        [JsonPropertyName("record_no")]
        public string RecordNo { get; set; }
    }
}
