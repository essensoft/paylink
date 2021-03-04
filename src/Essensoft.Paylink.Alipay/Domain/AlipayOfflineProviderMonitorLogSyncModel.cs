using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderMonitorLogSyncModel Data Structure.
    /// </summary>
    public class AlipayOfflineProviderMonitorLogSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据回流日志
        /// </summary>
        [JsonPropertyName("logs")]
        public List<ISVLogSync> Logs { get; set; }
    }
}
