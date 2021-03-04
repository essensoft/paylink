using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCreateResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预创建单单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }
    }
}
