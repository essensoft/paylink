using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要删除的渠道ID列表
        /// </summary>
        [JsonProperty("channel_ids")]
        public List<string> ChannelIds { get; set; }
    }
}
