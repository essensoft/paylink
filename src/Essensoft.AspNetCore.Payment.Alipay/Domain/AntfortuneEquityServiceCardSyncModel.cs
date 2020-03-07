using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityServiceCardSyncModel Data Structure.
    /// </summary>
    public class AntfortuneEquityServiceCardSyncModel : AlipayObject
    {
        /// <summary>
        /// 服务动态信息列表
        /// </summary>
        [JsonPropertyName("contents")]
        public List<FsServiceDynamicInfo> Contents { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
