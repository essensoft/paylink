using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
