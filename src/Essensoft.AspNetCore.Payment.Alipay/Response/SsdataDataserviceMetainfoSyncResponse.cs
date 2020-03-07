using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncResponse.
    /// </summary>
    public class SsdataDataserviceMetainfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 是否同步成功
        /// </summary>
        [JsonPropertyName("is_sync_success")]
        public bool IsSyncSuccess { get; set; }

        /// <summary>
        /// 返回同步成功或者失败的信息
        /// </summary>
        [JsonPropertyName("sync_result")]
        public string SyncResult { get; set; }
    }
}
