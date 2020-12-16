using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCityserviceUserPropertiesSendResponse.
    /// </summary>
    public class AlipayEcoCityserviceUserPropertiesSendResponse : AlipayResponse
    {
        /// <summary>
        /// 数据同步结果
        /// </summary>
        [JsonPropertyName("sync_result")]
        public string SyncResult { get; set; }
    }
}
