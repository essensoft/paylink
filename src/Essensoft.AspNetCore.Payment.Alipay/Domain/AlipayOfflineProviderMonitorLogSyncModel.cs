using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderMonitorLogSyncModel Data Structure.
    /// </summary>
    public class AlipayOfflineProviderMonitorLogSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据回流日志
        /// </summary>
        [JsonProperty("logs")]
        public List<ISVLogSync> Logs { get; set; }
    }
}
