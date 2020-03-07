using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 渠道修改接口
        /// </summary>
        [JsonPropertyName("channel_response")]
        public List<KbAdvertChannelResponse> ChannelResponse { get; set; }
    }
}
