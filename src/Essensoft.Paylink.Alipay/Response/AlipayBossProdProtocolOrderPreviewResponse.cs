using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdProtocolOrderPreviewResponse.
    /// </summary>
    public class AlipayBossProdProtocolOrderPreviewResponse : AlipayResponse
    {
        /// <summary>
        /// 协议预览结果
        /// </summary>
        [JsonPropertyName("protocol_preview_vo_list")]
        public ProtocolPreviewVO ProtocolPreviewVoList { get; set; }
    }
}
