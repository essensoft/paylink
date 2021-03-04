using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [JsonPropertyName("kb_ext_item_info")]
        public KbExtItemInfo KbExtItemInfo { get; set; }
    }
}
