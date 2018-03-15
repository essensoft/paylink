using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelDeleteModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionChannelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要删除的渠道ID列表
        /// </summary>
        [JsonProperty("channel_ids")]
        public List<string> ChannelIds { get; set; }
    }
}
