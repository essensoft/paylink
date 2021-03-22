using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JourneyServiceChangeInfo Data Structure.
    /// </summary>
    public class JourneyServiceChangeInfo : AlipayObject
    {
        /// <summary>
        /// 变更状态
        /// </summary>
        [JsonPropertyName("change_status")]
        public string ChangeStatus { get; set; }

        /// <summary>
        /// 详情url
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 提醒内容
        /// </summary>
        [JsonPropertyName("remind_content")]
        public string RemindContent { get; set; }
    }
}
