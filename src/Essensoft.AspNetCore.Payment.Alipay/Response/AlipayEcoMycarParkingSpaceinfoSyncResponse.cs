using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingSpaceinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingSpaceinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        [JsonPropertyName("sync_result")]
        public string SyncResult { get; set; }
    }
}
