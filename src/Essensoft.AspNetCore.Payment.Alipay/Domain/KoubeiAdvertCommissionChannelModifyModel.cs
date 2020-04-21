using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionChannelModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改渠道信息(新增、删除、修改渠道不可同时为空)
        /// </summary>
        [JsonPropertyName("channels")]
        public List<KbAdvertModifyChannelRequest> Channels { get; set; }
    }
}
