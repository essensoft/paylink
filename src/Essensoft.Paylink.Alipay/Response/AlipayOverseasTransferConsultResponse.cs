using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferConsultResponse.
    /// </summary>
    public class AlipayOverseasTransferConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 通道列表
        /// </summary>
        [JsonPropertyName("channel_list")]
        public List<string> ChannelList { get; set; }

        /// <summary>
        /// 默认通道
        /// </summary>
        [JsonPropertyName("default_channel")]
        public string DefaultChannel { get; set; }
    }
}
