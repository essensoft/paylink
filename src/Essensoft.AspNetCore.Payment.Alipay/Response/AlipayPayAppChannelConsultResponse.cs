using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayAppChannelConsultResponse.
    /// </summary>
    public class AlipayPayAppChannelConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 渠道信息列表
        /// </summary>
        [JsonPropertyName("channel_info_list")]
        public List<ChannelInfo> ChannelInfoList { get; set; }
    }
}
