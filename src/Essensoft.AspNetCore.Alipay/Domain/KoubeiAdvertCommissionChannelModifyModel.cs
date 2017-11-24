using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionChannelModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改渠道信息(新增、删除、修改渠道不可同时为空)
        /// </summary>
        [JsonProperty("channels")]
        public List<KbAdvertModifyChannelRequest> Channels { get; set; }
    }
}
